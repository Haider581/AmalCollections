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
using Microsoft.AspNetCore.Identity;

namespace AmalCollections.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly ACContext context;
        private readonly UserManager<User> usrMgr;

        public OrderController(ACContext context, UserManager<User> usrMgr)
        {
            this.context = context;
            this.usrMgr = usrMgr;
        }

        private int GetMaxDocId()
        {
            try
            {
                OrderDetail doc = context.OrderDetails.OrderByDescending(a => a.DocId)
                    .FirstOrDefault();
                if (doc == null)
                {
                    return 1;
                }

                return doc.DocId + 1;
            }
            catch
            {
                return 0;
            }
        }
        private List<OrderDetail> GetAll()
        {
            try
            {
                List<OrderDetail> data = context.OrderDetails
                    .Include(a => a.Customer)
                    .Include(a => a.Product).ThenInclude(a => a.Brand)
                    .Include(a => a.User)
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
                                      group new { o.Qty, o.Amount } by new { o.DocId, o.Date, o.Customer, o.UserId } into g

                                      select new OrderDetail
                                      {
                                          DocId = g.Key.DocId,
                                          Date = g.Key.Date,
                                          Customer = g.Key.Customer,
                                          UserId = g.Key.UserId,
                                          Qty = g.Sum(a => a.Qty),
                                          Amount = g.Sum(a => a.Amount)

                                      }).ToList();
            if(User.IsInRole("Customer"))
            {
                string userId = usrMgr.GetUserId(User);
                data = data.Where(a => a.UserId == userId).ToList();
            }
            return View(data);
        }
        public IActionResult Detail(long docId)
        {
            List<OrderDetail> data = GetAll().Where(a => a.DocId == docId).ToList();
            if (User.IsInRole("Customer"))
            {
                string userId = usrMgr.GetUserId(User);
                data = data.Where(a => a.UserId == userId).ToList();
            }
            return View(data);
        }

    }
}
