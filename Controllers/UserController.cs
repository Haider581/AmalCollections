using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AmalCollections.Models;
using Microsoft.AspNetCore.Identity;
using AmalCollections.Data;
using AmalCollections.VMs;
using Microsoft.AspNetCore.Http;

namespace AmalCollections.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> usrMgr;
        private readonly SignInManager<User> snMgr;
        private readonly IHttpContextAccessor http;
        private readonly RoleManager<IdentityRole> rMan;
        private readonly ACContext context;

        public UserController(UserManager<User> usrMgr, SignInManager<User> snMgr,
            IHttpContextAccessor http, RoleManager<IdentityRole> rMan, ACContext context)
        {
            this.usrMgr = usrMgr;
            this.snMgr = snMgr;
            this.http = http;
            this.rMan = rMan;
            this.context = context;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM vm, string returnUrl)
        {
            try
            {
                if (string.IsNullOrEmpty(vm.Username))
                {
                    ModelState.AddModelError("", "Error! Username cannot be empty");
                    return View(vm);
                }
                if (string.IsNullOrEmpty(vm.Password))
                {
                    ModelState.AddModelError("", "Error! Password cannot be empty");
                    return View(vm);
                }
                var SignInResult = await snMgr.PasswordSignInAsync(vm.Username, vm.Password, false, false);
                if (SignInResult.Succeeded)
                {
                    if (string.IsNullOrEmpty(returnUrl))
                    {
                        User u = await usrMgr.FindByNameAsync(vm.Username);
                        if(u != null)
                        {
                            var isAdmin = await usrMgr.IsInRoleAsync(u, "Admin");
                            if (isAdmin)
                            {
                                return RedirectToAction("Index", "Order");
                            }
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    return Redirect(returnUrl);
                }
                ModelState.AddModelError("", "Error! Username or password incorrect");
                return View(vm);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error! " + ex.Message);
                return View(vm);
            }
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM vm)
        {
            try
            {
                if (string.IsNullOrEmpty(vm.Username))
                {
                    ModelState.AddModelError("", "Error! Name cannot be empty");
                    return View(vm);
                }
                if (string.IsNullOrEmpty(vm.Password))
                {
                    ModelState.AddModelError("", "Error! Password cannot be empty");
                    return View(vm);
                }
                if (string.IsNullOrEmpty(vm.ConfirmPassword))
                {
                    ModelState.AddModelError("", "Error! Enter password again");
                    return View(vm);
                }
                if (vm.Password != vm.ConfirmPassword)
                {
                    ModelState.AddModelError("", "Error! Passwords do not match");
                    return View(vm);
                }

                var usr = await usrMgr.FindByNameAsync(vm.Username);
                if (usr != null)
                {
                    ModelState.AddModelError("", "Error! This username has already been taken");
                    return View(vm);
                }
                User newUser = new User();
                newUser.UserName = vm.Username;
                var createUserResult = await usrMgr.CreateAsync(newUser);
                if (createUserResult.Succeeded)
                {
                    var addPasswordResult = await usrMgr.AddPasswordAsync(newUser, vm.Password);
                    if (addPasswordResult.Succeeded)
                    {
                        var signInResult = await snMgr.PasswordSignInAsync(vm.Username, vm.Password, false, false);
                        if (signInResult.Succeeded)
                        {
                            var addRole = await usrMgr.AddToRoleAsync(newUser, "Customer");
                            if (addRole.Succeeded)
                            {
                                var user = await usrMgr.FindByNameAsync(vm.Username);
                                Customer c = new Customer();
                                c.FirstName = vm.FirstName;
                                c.LastName = vm.LastName;
                                c.UserId = user.Id;
                                context.Customers.Add(c);
                                context.SaveChanges();
                                return RedirectToAction("Index", "Home");
                            }
                            foreach (var err in addRole.Errors)
                            {
                                ModelState.AddModelError("", "Error! " + err.Description);
                            }
                            return View(vm);
                        }
                    }
                    foreach (var err in addPasswordResult.Errors)
                    {
                        ModelState.AddModelError("", "Error! " + err.Description);
                    }
                    return View(vm);
                }
                foreach (var err in createUserResult.Errors)
                {
                    ModelState.AddModelError("", "Error! " + err.Description);
                }
                return View(vm);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error! " + ex.Message);
                return View(vm);
            }
        }

        public async Task<IActionResult> Signout()
        {
            await snMgr.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<string> CreateRoles()
        {
            List<string> roles = new List<string>() { "Admin", "Customer" };
            foreach (string r in roles)
            {
                IdentityRole role = new IdentityRole(r);
                var roleResult = await rMan.CreateAsync(role);

            }
            return "Success";
        }
    }
}
