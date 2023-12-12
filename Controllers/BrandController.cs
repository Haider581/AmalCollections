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
    public class BrandController : Controller
    {
        private readonly ACContext context;
        private readonly IWebHostEnvironment env;
        private readonly string imageFolder = null;

        public BrandController(ACContext context, IWebHostEnvironment env)
        {
            this.context = context; 
            this.env = env;
            string[] p = { env.WebRootPath, "images", "brands" };
            imageFolder = Path.Combine(p);
        }

        private List<Brand> GetAll()
        {
            try
            {
                List<Brand> data = context.Brands.ToList();
                return data;
            }
            catch
            {
                return new List<Brand>();
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
        public async Task<IActionResult> Add(BrandVM vm)
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
                    ModelState.AddModelError("", "Error! Brand already exists");
                    return View(vm);
                }

                Brand c = new Brand();
                c.Name = vm.Name;

                string uniqueName = Guid.NewGuid().ToString() + ".jpg";
                string file = Path.Combine(imageFolder, uniqueName);
                using (FileStream fs = new FileStream(file, FileMode.Create))
                {
                   await vm.Image.CopyToAsync(fs);
                }

                c.ImagePath = uniqueName;
                c.IsActive = true;

                context.Brands.Add(c);
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
            BrandVM data = GetAll().Where(a => a.Id == id).Select(a => new BrandVM
            {
                Id = a.Id,
                Name = a.Name,
                InitialName = a.Name,
                IsActive = a.IsActive,
            }).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(BrandVM vm)
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
                        ModelState.AddModelError("", "Error! Brand already exists");
                        return View(vm);
                    }
                }
                using(IDbContextTransaction trans = context.Database.BeginTransaction())
                { 
                    Brand c = context.Brands.Where(a => a.Id == vm.Id).FirstOrDefault();
                    c.Name = vm.Name;

                    if(vm.Image != null)
                    {
                        Brand oldImages = context.Brands.Where(a => a.Id == vm.Id).FirstOrDefault();

                        string deleteFile = Path.Combine(imageFolder, oldImages.ImagePath);
                        System.IO.File.Delete(deleteFile);

                        string uniqueName = Guid.NewGuid().ToString() + ".jpg";
                        string file = Path.Combine(imageFolder, uniqueName);
                        using (FileStream fs = new FileStream(file, FileMode.Create))
                        {
                            await vm.Image.CopyToAsync(fs);
                        }
                        c.ImagePath = uniqueName;
                    }

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
            Brand data = context.Brands.Where(a => a.Name == name).FirstOrDefault();
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
                Product data = context.Products.Where(a => a.BrandId == Id).FirstOrDefault();

                if (data != null)
                {
                    return "Error! Entity already referenced!";
                }

                Brand oldImages = context.Brands.Where(a => a.Id == Id).FirstOrDefault();

                string deleteFile = Path.Combine(imageFolder, oldImages.ImagePath);
                System.IO.File.Delete(deleteFile);

                context.Brands.Remove(oldImages);
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
