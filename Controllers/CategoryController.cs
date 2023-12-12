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

namespace AmalCollections.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ACContext context;
        private readonly IWebHostEnvironment env;
        private readonly string imageFolder = null;

        public CategoryController(ACContext context, IWebHostEnvironment env)
        {
            this.context = context; 
            this.env = env;
            string[] p = { env.WebRootPath, "images", "collections" };
            imageFolder = Path.Combine(p);
        }

        private List<Category> GetAll()
        {
            try
            {
                List<Category> data = context.Categories.ToList();
                return data;
            }
            catch
            {
                return new List<Category>();
            }
        }

        public IActionResult Index()
        {
            return View(GetAll());
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category vm)
        {
            try
            {
                if(string.IsNullOrEmpty(vm.Name))
                {
                    ModelState.AddModelError("", "Error! please enter a name");
                    return View(vm);
                }

                if(Exists(vm.Name))
                {
                    ModelState.AddModelError("", "Error! Category already exists");
                    return View(vm);
                }

                Category c = new Category();
                c.Name = vm.Name;
                c.IsActive = true;

                context.Categories.Add(c);
                context.SaveChanges();


                return RedirectToAction("Index");

            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", "Error! " + ex.Message);
                return View(vm);
            }
        }

        public IActionResult Edit(int id)
        {
            CategoryVM data = GetAll().Where(a => a.Id == id).Select(a => new CategoryVM
            {
                Id = a.Id,
                Name = a.Name,
                InitialName = a.Name,
                IsActive = a.IsActive,
            }).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(CategoryVM vm)
        {
            try
            {
                if (string.IsNullOrEmpty(vm.Name))
                {
                    ModelState.AddModelError("", "Error! please enter a name");
                    return View(vm);
                }

                if(vm.InitialName != vm.Name)
                {
                    if (Exists(vm.Name))
                    {
                        ModelState.AddModelError("", "Error! Category already exists");
                        return View(vm);
                    }
                }
                using(IDbContextTransaction trans = context.Database.BeginTransaction())
                {
                    Category c = context.Categories.Where(a => a.Id == vm.Id).FirstOrDefault();
                    c.Name = vm.Name;
                    c.IsActive = true;

                    context.SaveChanges();

                    trans.Commit();
                }
              

                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error! " + ex.Message);
                return View(vm);
            }
        }
        
        private bool Exists(string name)
        {
            Category data = context.Categories.Where(a => a.Name == name).FirstOrDefault();
            if(data == null)
            {
                return false;
            }
            return true;
        }

        public string Remove(int Id)
        {
            try
            {
                Product data = context.Products.Where(a => a.CategoryId == Id).FirstOrDefault();

                if (data != null)
                {
                    return "Error! Entity already referenced!";
                }

                Category cat = context.Categories.Where(a => a.Id == Id).FirstOrDefault(); 
                
                if (cat.Name == "All")
                {
                    return "Error! Cannot delete default category";
                }

                context.Categories.Remove(cat);
                context.SaveChanges();

                return "Success";
            }
            catch (Exception ex)
            {
                return "Error! " + ex.Message;
            }
        }
    }
}
