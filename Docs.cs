using AmalCollections.Data;
using AmalCollections.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmalCollections
{
    public class Docs
    {
        private readonly ACContext context;

        public Docs(ACContext context)
        {
            this.context = context;
        }

        public int GetMaxDocId()
        {
            try
            {
                OrderDetail od = context.OrderDetails.OrderByDescending(a => a.DocId).FirstOrDefault();
                if(od == null)
                {
                    return 1;
                }
                return od.DocId + 1;
            }
            catch
            {
                return 0;
            }
        }

        public string Add(List<DocVM> vm)
        {
            try
            {
                DocVM doc = vm.FirstOrDefault();
                doc.DocId = GetMaxDocId();
                doc.DocType = "Sale";
                foreach (var item in vm)
                {
                    Product p = context.Products.Where(a => a.Id == item.ProductId).FirstOrDefault();
                    OrderDetail od = new OrderDetail();
                    od.DocId = doc.DocId;
                    od.DocType = doc.DocType;
                    od.Date = doc.Date;
                    od.CustomerId = doc.CustomerId;
                    od.ProductId = item.ProductId;
                    od.Stock = item.Qty * -1;
                    od.Qty = item.Qty;
                    od.Rate = p.SalePrice;
                    od.Amount = Math.Round(item.Qty * p.SalePrice, 0);
                    od.DiscountPercent = 0;
                    od.Discount = 0;
                    od.NetAmount = Math.Round(item.Qty * p.SalePrice, 0);
                    od.Status = "Pending";
                    od.UserId = doc.UserId;

                    context.OrderDetails.Add(od);
                    context.SaveChanges();
                }
                return doc.DocId.ToString(); 
            }
            catch(Exception ex)
            {
                return "Error! " + ex.Message;
            }
        }
    }
}
