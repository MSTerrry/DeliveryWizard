using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeliveryWizard;
using DW.Web.Models;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace DW.Web.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Print(HttpPostedFileBase file)
        {            
            if (file != null && file.ContentLength > 0)
            {
                var dto = DeliverySerializer.LoadFromStream(file.InputStream);                
                using (var db = new ApplicationDbContext())
                {
                    var row = new DbDeliveryRquest
                    {
                        ClientAddress = dto.ClientAddress,
                        Filled = dto.Filled,
                        TimeDeliver = dto.TimeDeliver,
                        TotalCost = dto.TotalCost,
                        FullName = dto.FullName
                    };

                    row.WayPoints = new Collection<DbWayPoint>();
                    foreach (var wpDto in dto.WayPoints)
                    {
                        var wp = new DbWayPoint
                        {
                            Address = wpDto.Address,
                            PlaceTitle = wpDto.PlaceTitle,
                            ShopType = wpDto.ShopType,
                            TotalCost = wpDto.TotalCost
                        };
                        row.WayPoints.Add(wp);
                        wp.ProductsList = new Collection<DbProduct>();
                        foreach (var product in wpDto.ProductsList)
                        {
                            var p = new DbProduct
                            {
                                Name = product.Name,
                                Amount = product.Amount,
                                Additions = product.Additions,
                                Cost = product.Cost,
                            };
                            wp.ProductsList.Add(p);
                        }
                        db.productList.AddRange(wp.ProductsList);
                    }
                    db.DeliveryRequest.Add(row);
                    db.SaveChanges();
                    return View(dto);
                }
            }
                return RedirectToAction("Index");            
        }
    }
}