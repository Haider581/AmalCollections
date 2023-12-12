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
using Microsoft.AspNetCore.Mvc.Rendering;
using AmalCollections.VMs;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq.Expressions;

namespace AmalCollections.Controllers
{
    public class ProductController : Controller
    {
        private readonly ACContext context;
        private readonly IWebHostEnvironment env;
        private readonly string imageFolder = null;
        private readonly List<Brand> brands;
        private readonly List<Category> categories;

        public ProductController(ACContext context, IWebHostEnvironment env)
        {
            this.context = context;
            this.env = env;
            string[] p = { env.WebRootPath, "images", "products" };
            imageFolder = Path.Combine(p);
            brands = context.Brands.ToList();
            categories = context.Categories.ToList();
        }

        private List<Product> GetAll()
        {
            try
            {
                List<Product> products = context.Products
                    .Include(a => a.Brand)
                    .Include(a => a.Category)
                    .Include(a => a.ProductImages)
                    .ToList();
                return products;
            }
            catch
            {
                return new List<Product>();
            }
        }

        public IActionResult Index(int id, int catId, int sortId)
        {
            Func<Product, bool> pred;
            ViewBag.BrandId = id;
            ViewBag.Brand = context.Brands.Where(a => a.Id == id).FirstOrDefault() == null ? "" : context.Brands.Where(a => a.Id == id).FirstOrDefault().Name;
            ViewBag.CategoryId = catId;
            ViewBag.Category = context.Categories.Where(a => a.Id == catId).FirstOrDefault() == null ? "" : context.Categories.Where(a => a.Id == catId).FirstOrDefault().Name;
            ViewBag.SortId = sortId;
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            List<ProductVM> data = new List<ProductVM>();
            if(catId == 1)
            {
                pred = a => a.BrandId == id;
            }
            else
            {
                pred = a => a.BrandId == id && a.CategoryId == catId;
            }
            var products = GetAll().Where(pred)
                .Select(a => new
                {
                    a.Id,
                    a.Brand,
                    a.Category,
                    a.Name,
                    a.SalePrice,
                    a.LastUpdated,
                    a.IsBestSelling,
                    a.IsFeatured,
                    ProductImage = a.ProductImages.Where(a => a.IsMain == true).FirstOrDefault()

                }).Distinct().ToList();
            foreach (var item in products)
            {
                ProductVM p = new ProductVM();
                p.Id = item.Id;
                p.Brand = item.Brand;
                p.Category = item.Category;
                p.Name = item.Name;
                p.SalePrice = item.SalePrice;
                p.LastUpdated = item.LastUpdated;
                p.IsBestSelling = item.IsBestSelling;
                p.IsFeatured = item.IsFeatured;
                p.ImagePath = item.ProductImage.ImagePath;
                data.Add(p);
            }
            if (sortId == 1)
            {
                data = data.Where(a => a.IsFeatured == true).ToList();
            }
            if (sortId == 2)
            {
                data = data.Where(a => a.IsBestSelling == true).ToList();
            }
            if (sortId == 3)
            {
                data = data.OrderBy(a => a.Name).ToList();
            }
            if (sortId == 4)
            {
                data = data.OrderByDescending(a => a.Name).ToList();
            }
            if (sortId == 5)
            {
                data = data.OrderBy(a => a.SalePrice).ToList();
            }
            if (sortId == 6)
            {
                data = data.OrderByDescending(a => a.SalePrice).ToList();
            }
            if (sortId == 7)
            {
                data = data.OrderByDescending(a => a.LastUpdated).ToList();
            }
            if (sortId == 8)
            {
                data = data.OrderBy(a => a.LastUpdated).ToList();
            }
            return View(data);
        }
        public IActionResult IndexP(string name)
        {
            List<ProductVM> data = new List<ProductVM>();
            if(string.IsNullOrEmpty(name))
            {
                return PartialView("IndexP", data);
            }
            Func<Product, bool> pred;
            ViewBag.Name = name;
            pred = a => a.Name.ToLower().Contains(name.ToLower());
            var products = GetAll().Where(pred)
                .Select(a => new
                {
                    a.Id,
                    a.Brand,
                    a.Category,
                    a.Name,
                    a.SalePrice,
                    a.LastUpdated,
                    a.IsBestSelling,
                    a.IsFeatured,
                    ProductImage = a.ProductImages.Where(a => a.IsMain == true).FirstOrDefault()

                }).Distinct().ToList();
            foreach (var item in products)
            {
                ProductVM p = new ProductVM();
                p.Id = item.Id;
                p.Brand = item.Brand;
                p.Category = item.Category;
                p.Name = item.Name;
                p.SalePrice = item.SalePrice;
                p.LastUpdated = item.LastUpdated;
                p.IsBestSelling = item.IsBestSelling;
                p.IsFeatured = item.IsFeatured;
                p.ImagePath = item.ProductImage.ImagePath;
                data.Add(p);
            }
            return PartialView("IndexP", data);
        }
        public IActionResult Details(long id)
        {
            Product data = GetAll().Where(a => a.Id == id).FirstOrDefault();
            return View(data);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult List()
        {
            List<ProductVM> data = new List<ProductVM>();
            var products = GetAll()
                .Select(a => new
                {
                    a.Id,
                    a.Brand,
                    a.Category,
                    a.Name,
                    a.Description,
                    a.IsActive
                }).Distinct().ToList();
            foreach (var item in products)
            {
                ProductVM p = new ProductVM();
                p.Id = item.Id;
                p.Brand = item.Brand;
                p.Category = item.Category;
                p.Name = item.Name;
                p.Description = item.Description;
                p.IsActive = item.IsActive;
                data.Add(p);
            }
            return View(data);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Add()
        {
            ViewBag.Brands = new SelectList(brands, "Id", "Name");
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            return View();
        }
        [Authorize(Roles = "Admin"), HttpPost]
        public async Task<IActionResult> Add(ProductVM vm)
        {
            ViewBag.Brands = new SelectList(brands, "Id", "Name");
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            try
            {
                if (vm.CategoryId == 0)
                {
                    ModelState.AddModelError("", "Error! Please select a category from list");
                    return View(vm);
                }
                if (string.IsNullOrEmpty(vm.Name))
                {
                    ModelState.AddModelError("", "Error! Please enter name");
                    return View(vm);
                }
                if (vm.CostPrice == 0)
                {
                    ModelState.AddModelError("", "Error! Please enter cost price");
                    return View(vm);
                }
                if (vm.SalePrice == 0)
                {
                    ModelState.AddModelError("", "Error! Please enter sale price");
                    return View(vm);
                }
                if (vm.Images == null)
                {
                    ModelState.AddModelError("", "Error! Please select atlease one image");
                    return View(vm);
                }
                if (vm.Images.Count > 3)
                {
                    ModelState.AddModelError("", "Error! Only three images can be uploaded");
                    return View(vm);
                }

                using (IDbContextTransaction trans = context.Database.BeginTransaction())
                {
                    Product p = new Product();
                    p.BrandId = vm.BrandId;
                    p.CategoryId = vm.CategoryId;
                    p.Name = vm.Name;
                    p.Description = vm.Description;
                    p.CostPrice = vm.CostPrice;
                    p.SalePrice = vm.SalePrice;
                    p.LastUpdated = vm.LastUpdated;
                    p.IsFeatured = vm.IsFeatured;
                    p.IsBestSelling = vm.IsBestSelling;
                    p.IsActive = true;

                    context.Products.Add(p);
                    context.SaveChanges();

                    int count = 0;
                    foreach (var item in vm.Images)
                    {
                        count += 1;
                        string uniqueName = Guid.NewGuid().ToString() + '_' + p.Id.ToString() + ".jpg";
                        string file = Path.Combine(imageFolder, uniqueName);
                        using (FileStream fs = new FileStream(file, FileMode.Create))
                        {
                            await item.CopyToAsync(fs);
                        }

                        ProductImage pi = new ProductImage();
                        pi.CategoryId = p.CategoryId;
                        pi.ProductId = p.Id;
                        pi.ImagePath = uniqueName;
                        if (count == 1)
                        {
                            pi.IsMain = true;
                        }
                        else
                        {
                            pi.IsMain = false;
                        }
                        context.ProductImages.Add(pi);
                        context.SaveChanges();
                    }

                    trans.Commit();
                    return RedirectToAction("List");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error! " + ex.Message);
                return View(vm);
            }
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(long id)
        {
            ViewBag.Brands = new SelectList(brands, "Id", "Name");
            ViewBag.Categories = new SelectList(categories, "Id", "Name");

            ProductVM data = GetAll().Where(a => a.Id == id)
                .Select(a => new ProductVM
                {
                    Id = a.Id,
                    BrandId = a.BrandId,
                    Brand = a.Brand,
                    CategoryId = a.CategoryId,
                    Category = a.Category,
                    Name = a.Name,
                    Description = a.Description,
                    CostPrice = a.CostPrice,
                    SalePrice = a.SalePrice,
                    LastUpdated = a.LastUpdated,
                    IsFeatured = a.IsFeatured,
                    IsBestSelling = a.IsBestSelling

                }).FirstOrDefault();
            return View(data);
        }
        [Authorize(Roles = "Admin"), HttpPost]
        public async Task<IActionResult> Edit(ProductVM vm)
        {
            ViewBag.Brands = new SelectList(brands, "Id", "Name");
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            try
            {
                if (vm.CategoryId == 0)
                {
                    ModelState.AddModelError("", "Error! Please select a category from list");
                    return View(vm);
                }
                if (string.IsNullOrEmpty(vm.Name))
                {
                    ModelState.AddModelError("", "Error! Please enter name");
                    return View(vm);
                }
                if (vm.CostPrice == 0)
                {
                    ModelState.AddModelError("", "Error! Please enter cost price");
                    return View(vm);
                }
                if (vm.SalePrice == 0)
                {
                    ModelState.AddModelError("", "Error! Please enter sale price");
                    return View(vm);
                }

                using (IDbContextTransaction trans = context.Database.BeginTransaction())
                {
                    Product p = context.Products.Where(a => a.Id == vm.Id).FirstOrDefault();
                    p.BrandId = vm.BrandId;
                    p.CategoryId = vm.CategoryId;
                    p.Name = vm.Name;
                    p.Description = vm.Description;
                    p.CostPrice = vm.CostPrice;
                    p.SalePrice = vm.SalePrice;
                    p.LastUpdated = vm.LastUpdated;
                    p.IsFeatured = vm.IsFeatured;
                    p.IsBestSelling = vm.IsBestSelling;
                    p.IsActive = true;

                    context.SaveChanges();

                    if (vm.Images != null && vm.Images.Count > 0)
                    {
                        if (vm.Images.Count > 3)
                        {
                            ModelState.AddModelError("", "Error! Only three images can be uploaded");
                            return View(vm);
                        }

                        List<ProductImage> oldImages = context.ProductImages.Where(a => a.ProductId == p.Id).ToList();
                        if (oldImages.Count > 0)
                        {
                            foreach (var im in oldImages)
                            {
                                string file = Path.Combine(imageFolder, im.ImagePath);
                                System.IO.File.Delete(file);
                            }

                            context.ProductImages.RemoveRange(oldImages);
                            context.SaveChanges();
                        }
                        int count = 0;
                        foreach (var item in vm.Images)
                        {
                            count += 1;
                            string uniqueName = Guid.NewGuid().ToString() + '_' + p.Id.ToString() + ".jpg";
                            string file = Path.Combine(imageFolder, uniqueName);
                            using (FileStream fs = new FileStream(file, FileMode.Create))
                            {
                                await item.CopyToAsync(fs);
                            }

                            ProductImage pi = new ProductImage();
                            pi.CategoryId = p.CategoryId;
                            pi.ProductId = p.Id;
                            pi.ImagePath = uniqueName;
                            if (count == 1)
                            {
                                pi.IsMain = true;
                            }
                            else
                            {
                                pi.IsMain = false;
                            }
                            context.ProductImages.Add(pi);
                            context.SaveChanges();
                        }
                    }

                    trans.Commit();
                    return RedirectToAction("List");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error! " + ex.Message);
                return View(vm);
            }
        }

        [Authorize(Roles = "Admin")]
        public string Remove(int Id)
        {
            try
            {
                using (IDbContextTransaction trans = context.Database.BeginTransaction())
                {

                    Product data = context.Products.Where(a => a.Id == Id).FirstOrDefault();

                    List<ProductImage> oldImages = context.ProductImages.Where(a => a.ProductId == Id).ToList();
                    if (oldImages.Count > 0)
                    {
                        foreach (var im in oldImages)
                        {
                            string file = Path.Combine(imageFolder, im.ImagePath);
                            System.IO.File.Delete(file);
                        }

                        context.ProductImages.RemoveRange(oldImages);
                        context.SaveChanges();
                    }

                    context.Products.Remove(data);
                    context.SaveChanges();

                    trans.Commit();

                }
                return "Success";
            }
            catch (Exception ex)
            {
                return "Error! " + ex.Message;
            }
        }
    }
}
