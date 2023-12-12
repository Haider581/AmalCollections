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

namespace AmalCollections.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly ACContext context;
        public AdminController(ACContext context)
        {
            this.context = context;
        }
        private List<OrderDetail> GetAll()
        {
            try
            {
                List<OrderDetail> data = context.OrderDetails
                    .Include(a => a.Customer)
                    .Include(a => a.Product)
                    .ToList();
                return data;
            }
            catch
            {
                return new List<OrderDetail>();
            }
        }
       
        public IActionResult Index()
        {
            List<OrderDetail> data = (from o in GetAll()
                                      group new { o.Qty, o.Amount } by new { o.DocId, o.Date, o.Customer} into g

                                      select new OrderDetail 
                                      { 
                                          DocId = g.Key.DocId,
                                          Date = g.Key.Date,
                                          Customer = g.Key.Customer,
                                          Qty = g.Sum(a => a.Qty),
                                          Amount = g.Sum(a => a.Amount)

                                      }).ToList();
            return View(data);
        }
        public IActionResult Detail(long docId)
        {
            List<OrderDetail> data = GetAll().Where(a => a.DocId == docId).ToList();
            return View(data);
        }
    }
}
