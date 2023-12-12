using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AmalCollections.Models;
using Microsoft.AspNetCore.Authorization;
using AmalCollections.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using AmalCollections.VMs;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage;

namespace AmalCollections.Controllers
{
    public class CartController : Controller
    {
        private readonly ACContext context;
        private readonly UserManager<User> usrMgr;
        private readonly SignInManager<User> snMgr;
        private readonly IHttpContextAccessor http;
        private readonly Docs docs;

        public CartController(ACContext context, UserManager<User> usrMgr, SignInManager<User> snMgr, IHttpContextAccessor http)
        {
            this.context = context;
            this.usrMgr = usrMgr;
            this.snMgr = snMgr;
            this.http = http;
            docs = new Docs(context);
        }

        public List<DocVM> GetCart()
        {
            string cookie = GetCookie().Value;
            List<DocVM> data = context.Carts.Where(a => a.Cookie == cookie)
                .Include(a => a.Product)
                .Select(a => new DocVM
                {
                    ProductId = a.ProductId,
                    Product = a.Product,
                    Rate = a.Product.SalePrice,
                    Qty = a.Qty

                }).OrderBy(a => a.ProductId).ToList();
            return data;
        }
        public double CartTotal()
        {
            var count = (from c in GetCart()
                         group c.Qty by 1 into g

                         select new
                         {
                             Qty = g.Sum()
                         }).FirstOrDefault();
            if(count == null)
            {
                return 0;
            }

            return count.Qty;
        }
        public IActionResult Index()
        {
            var cookieData = Request.Cookies["Cookie"];
            if (cookieData != null)
            {
                List<Cart> data = context.Carts.Where(a => a.Cookie == cookieData)
                    .Include(a => a.Product)
                    .ThenInclude(a => a.ProductImages)
                    .ToList();

                return View(data);
            }

            return View();
        }

        [HttpPost]
        public string Add(DocVM vm)
        {
            try
            {
                CookieVM cook = GetCookie();
                List<Cart> c = context.Carts.Where(a => a.Cookie == cook.Value
                && a.ProductId == vm.ProductId).ToList();
                if (c.Count > 0)
                {
                    cook.Expiry = c.FirstOrDefault().Expiry;
                    context.Carts.RemoveRange(c);
                    context.SaveChanges();
                }

                Cart ct = new Cart();
                ct.ProductId = vm.ProductId;
                ct.Qty = vm.Qty;
                ct.Cookie = cook.Value;
                ct.Expiry = cook.Expiry;

                if (User != null)
                {
                    ct.UserId = usrMgr.GetUserId(User);
                }

                context.Carts.Add(ct);
                context.SaveChanges();

                var cartTotal = (from cat in context.Carts.Where(a => a.Cookie == cook.Value)
                                 group cat.Qty by cat.Cookie into g

                                 select new
                                 {
                                     Qty = g.Sum()
                                 }).FirstOrDefault();

                int TotalQty = cartTotal == null ? 0 : cartTotal.Qty;
                return TotalQty.ToString();
            }
            catch (Exception ex)
            {
                return "Error! " + ex.Message + " " + (ex.InnerException == null ? "" : ex.InnerException.Message);
            }
        }

        public IActionResult CartDetail()
        {
            string cookie = GetCookie().Value;
            List<DocVM> data = context.Carts.Where(a => a.Cookie == cookie)
                .Include(a => a.Product)
                .Select(a => new DocVM
                {
                    ProductId = a.ProductId,
                    Product = a.Product,
                    Rate = a.Product.SalePrice,
                    Qty = a.Qty

                }).OrderBy(a => a.ProductId).ToList();
            foreach (var item in data)
            {
                ProductImage img = context.ProductImages.Where(a => a.ProductId == item.ProductId && a.IsMain == true).FirstOrDefault();
                if (img != null)
                {
                    item.ImagePath = img.ImagePath;
                }
            }
            return View(data);
        }

        public IActionResult Complete()
        {
            string cookie = GetCookie().Value;
            List<DocVM> data = context.Carts.Where(a => a.Cookie == cookie)
                .Include(a => a.Product)
                .Select(a => new DocVM
                {
                    ProductId = a.ProductId,
                    Product = a.Product,
                    Rate = a.Product.SalePrice,
                    Qty = a.Qty

                }).OrderBy(a => a.ProductId).ToList();
            foreach (var item in data)
            {
                ProductImage img = context.ProductImages.Where(a => a.ProductId == item.ProductId && a.IsMain == true).FirstOrDefault();
                if (img != null)
                {
                    item.ImagePath = img.ImagePath;
                }
            }
            return View(data);
        }
        [HttpPost]
        public async Task<string> Complete(RegisterVM vm)
        {
            try
            {
                if (string.IsNullOrEmpty(vm.Email))
                {
                    return "Error! Please enter an email";
                }
                if (string.IsNullOrEmpty(vm.FirstName))
                {
                    return "Error! Please enter first name";
                }
                if (string.IsNullOrEmpty(vm.Address))
                {
                    return "Error! Please enter complete address";
                }
                if (string.IsNullOrEmpty(vm.City))
                {
                    return "Error! Please enter city name";
                }
                if (snMgr.IsSignedIn(User))
                {

                }
                Customer cus = context.Customers.Where(a => a.Email == vm.Email).FirstOrDefault();
                if (cus != null)
                {
                    return "Error! Customer with same email or mobile number already exists";
                }
                using (IDbContextTransaction trans = context.Database.BeginTransaction())
                {
                    Customer c = new Customer();
                    c.Email = vm.Email;
                    c.FirstName = vm.FirstName;
                    c.LastName = vm.LastName;
                    c.Address = vm.Address;
                    c.City = vm.City;
                    c.PostalCode = vm.PostalCode;
                    c.Phone = vm.Phone;
                    c.Country = "Pakistan";

                    context.Customers.Add(c);
                    context.SaveChanges();

                    vm.Id = c.Id;
                    string regMsg = await Register(vm);
                    if (regMsg.Contains("Error"))
                    {
                        return regMsg;
                    }
                    User u = context.Users.Where(a => a.UserName == vm.Email).FirstOrDefault();

                    List<DocVM> items = GetCart();
                    if (items.Count == 0)
                    {
                        return "Error! Cart is empty please select a product";
                    }

                    foreach (var item in items)
                    {
                        item.CustomerId = c.Id;
                        item.Date = DateTime.Now;
                        item.UserId = u.Id;
                    }
                    string odMsg = docs.Add(items);
                    if (odMsg.Contains("Error"))
                    {
                        return odMsg;
                    }

                    string delCartMsg = DeleteCart();
                    if (delCartMsg.Contains("Error"))
                    {
                        return delCartMsg;
                    }

                    trans.Commit();
                    return odMsg;
                }
            }
            catch (Exception ex)
            {
                return "Error! " + ex.Message;
            }
        }
        public IActionResult CheckOut()
        {

            var cookieData = Request.Cookies["Cookie"];
            if (cookieData != null)
            {
                List<Cart> data = context.Carts.Where(a => a.Cookie == cookieData)
                    .Include(a => a.Product)
                    .ThenInclude(a => a.ProductImages)
                    .ToList();

                return View(data);
            }

            return View();
        }

        public string Remove(long id)
        {
            string cookie = GetCookie().Value;
            try
            {
                Cart c = context.Carts.Where(a => a.Cookie == cookie
                && a.ProductId == id).FirstOrDefault();
                if (c != null)
                {
                    context.Carts.Remove(c);
                    context.SaveChanges();
                }
                return "Success";
            }
            catch (Exception ex)
            {
                return "Error! " + ex.Message + " " + (ex.InnerException == null ? "" : ex.InnerException.Message);
            }
        }

        public CookieVM GetCookie()
        {
            DeleteExpiredCookie();
            CookieVM c = new CookieVM();
            string cookie = http.HttpContext.Request.Cookies["Cart"];
            if (string.IsNullOrEmpty(cookie))
            {
                string key = "Cart";
                string value = Guid.NewGuid().ToString();
                DateTime expriy = DateTime.Now.AddDays(1);
                CookieOptions op = new CookieOptions();
                op.Expires = expriy;

                http.HttpContext.Response.Cookies.Append(key, value, op);

                c.Key = key;
                c.Value = value;
                c.Expiry = expriy;

                return c;
            }

            c.Key = "Cart";
            c.Value = cookie;
            return c;
        }

        public void DeleteExpiredCookie()
        {
            DateTime currDate = DateTime.Now.AddDays(3);
            List<Cart> c = context.Carts.Where(a => a.Expiry > currDate).ToList();

            if (c.Count > 0)
            {
                context.Carts.RemoveRange(c);
                context.SaveChanges();
                return;
            }
        }

        public string DeleteCart()
        {
            try
            {
                string cookie = GetCookie().Value;
                List<Cart> data = context.Carts.Where(a => a.Cookie == cookie).ToList();
                if (data.Count > 0)
                {
                    context.Carts.RemoveRange(data);
                    context.SaveChanges();
                }
                return "Success";
            }
            catch (Exception ex)
            {
                return "Error! " + ex.Message;
            }
        }

        private async Task<string> Register(RegisterVM vm)
        {
            try
            {
                User newUser = new User();
                newUser.UserName = vm.Email;
                newUser.CustomerId = vm.Id;
                var createUserResult = await usrMgr.CreateAsync(newUser);
                if (createUserResult.Succeeded)
                {
                    var addRole = await usrMgr.AddToRoleAsync(newUser, "Customer");
                    if (addRole.Succeeded)
                    {
                        var addPasswordResult = await usrMgr.AddPasswordAsync(newUser, "abc123");
                        if (addPasswordResult.Succeeded)
                        {
                            await snMgr.SignInAsync(newUser, true);
                            return "Success";
                        }
                        return "Error! " + addPasswordResult.Errors.FirstOrDefault().Description;
                    }
                    return "Error! " + addRole.Errors.FirstOrDefault().Description;
                    //var addPasswordResult = await usrMgr.AddPasswordAsync(newUser, vm.Password);
                    //if (addPasswordResult.Succeeded)
                    //{
                    //    var signInResult = await snMgr.PasswordSignInAsync(vm.Username, vm.Password, false, false);
                    //    if (signInResult.Succeeded)
                    //    {
                    //        var addRole = await usrMgr.AddToRoleAsync(newUser, "Customer");
                    //        if (addRole.Succeeded)
                    //        {
                    //            return "Success";
                    //        }
                    //        return "Error! " + addRole.Errors.FirstOrDefault().Description;
                    //    }
                    //}
                    //return "Error! " + addPasswordResult.Errors.FirstOrDefault().Description;
                }
                return "Error! " + createUserResult.Errors.FirstOrDefault().Description;
            }
            catch (Exception ex)
            {
                return "Error! " + ex.Message;
            }
        }
    }
}
