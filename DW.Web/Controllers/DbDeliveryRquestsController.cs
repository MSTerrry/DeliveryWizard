using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DW.Web.Models;
using System.Data.SqlClient;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using System.Web.Hosting;

namespace DW.Web.Controllers
{
    public class DbDeliveryRquestsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DbDeliveryRquests
        public ActionResult Index()
        {
            return View(db.DeliveryRequest.ToList());
        }

        // GET: DbDeliveryRquests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DbDeliveryRquest dbDeliveryRquest = db.DeliveryRequest.Find(id);
            if (dbDeliveryRquest == null)
            {
                return HttpNotFound();
            }
            return View(dbDeliveryRquest);
        }

        // GET: DbDeliveryRquests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DbDeliveryRquests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Filled,FullName,TimeDeliver,ClientAddress,TotalCost")] DbDeliveryRquest dbDeliveryRquest)
        {
            if (ModelState.IsValid)
            {
                db.DeliveryRequest.Add(dbDeliveryRquest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dbDeliveryRquest);
        }

        // GET: DbDeliveryRquests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DbDeliveryRquest dbDeliveryRquest = db.DeliveryRequest.Find(id);
            if (dbDeliveryRquest == null)
            {
                return HttpNotFound();
            }
            return View(dbDeliveryRquest);
        }

        // POST: DbDeliveryRquests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Filled,FullName,TimeDeliver,ClientAddress,TotalCost")] DbDeliveryRquest dbDeliveryRquest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dbDeliveryRquest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dbDeliveryRquest);
        }

        // GET: DbDeliveryRquests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DbDeliveryRquest dbDeliveryRquest = db.DeliveryRequest.Find(id);            
            if (dbDeliveryRquest == null)
            {
                return HttpNotFound();
            }
            return View(dbDeliveryRquest);
        }

        // POST: DbDeliveryRquests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            string connection = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=D:\универ\2 курс\c#\anytask\DeliveryWizard\DW.Web\App_Data\aspnet-DW.Web-20180422100716.mdf;Initial Catalog=aspnet-DW.Web-20180422100716;Integrated Security=True";            
            using (SqlConnection sqlcon = new SqlConnection(connection))
            {
                sqlcon.Open();
                string querryWPId = "SELECT Id FROM DbWayPoints WHERE DbDeliveryRquest_Id = '" + id + "'";
                string querryDelete = "DELETE FROM DbWayPoints WHERE DbDeliveryRquest_Id = '" + id + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querryWPId, connection);

                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    var prodId = Convert.ToInt32(dtbl.Rows[i][0].ToString());
                    string querryDeletePr = "DELETE FROM DbProducts WHERE DbWayPoint_Id = '" + prodId + "'";
                    SqlCommand deletePrCmd = new SqlCommand(querryDeletePr, sqlcon);
                    deletePrCmd.ExecuteNonQuery();
                }
                SqlCommand deleteCmd = new SqlCommand(querryDelete, sqlcon);
                deleteCmd.ExecuteNonQuery();

                string querryDeleteDto = "DELETE FROM DbDeliveryRquests WHERE Id = '" + id + "'";
                SqlCommand deleteDtoCmd = new SqlCommand(querryDeleteDto, sqlcon);
                deleteDtoCmd.ExecuteNonQuery();
            }                   
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Print(int? id)
        {
            var ctx = new ApplicationDbContext();
            var g = ctx.DeliveryRequest.Find(id);

            ExcelPackage pkg;
            using (var stream = System.IO.File.OpenRead(HostingEnvironment.ApplicationPhysicalPath + "template.xlsx"))
            {
                pkg = new ExcelPackage(stream);
                stream.Dispose();
            }

            var worksheet = pkg.Workbook.Worksheets[1];
            worksheet.Name = "Информация о заказе";

            worksheet.Cells[2, 3].Value = g.FullName;
            worksheet.Cells[3, 3].Value = g.Filled.ToString();
            worksheet.Cells[4, 3].Value = g.ClientAddress;
            worksheet.Cells[5, 3].Value = g.TimeDeliver.ToString();
            worksheet.Cells[6, 3].Value = g.TotalCost;            
            var row = 2;
            var column = 7;
            var tableColumn = 10;
            foreach (var e in g.WayPoints)
            {
                worksheet.Cells[row, column].Value = "Название места";
                worksheet.Cells[row + 1, column].Value = "Адрес";
                worksheet.Cells[row + 2, column].Value = "Тип места";
                worksheet.Cells[row + 3, column].Value = "общая стоимость покупок в этом месте";
                worksheet.Cells[row, column+1].Value = e.PlaceTitle;
                worksheet.Cells[row + 1, column+1].Value = e.Address;
                worksheet.Cells[row + 2, column+1].Value = e.ShopType;
                worksheet.Cells[row + 3, column+1].Value = e.TotalCost;
                var temp = row + 3;
                worksheet.Cells[row, tableColumn].Value = "Название";
                worksheet.Cells[row, tableColumn+1].Value = "Количество";
                worksheet.Cells[row, tableColumn+2].Value = "Дополнительная информация";
                worksheet.Cells[row, tableColumn+3].Value = "Цена";                
                var startRow = row;
                foreach (var pr in e.ProductsList)
                {
                    row = row + 1;
                    worksheet.Cells[row, tableColumn].Value = pr.Name;
                    worksheet.Cells[row, tableColumn + 1].Value = pr.Amount;
                    worksheet.Cells[row , tableColumn + 2].Value = pr.Additions;
                    worksheet.Cells[row, tableColumn + 3].Value = pr.Cost;                                 
                }
                row = temp > row ? temp+2 : row+2;
                using (var cells = worksheet.Cells[startRow, tableColumn, startRow + e.ProductsList.Count, tableColumn + 3])
                {
                    cells.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    cells.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    cells.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;                    
                }
            }
            worksheet.Cells.AutoFitColumns();
            var ms = new MemoryStream();
            pkg.SaveAs(ms);

            return File(ms.ToArray(), "application/ooxml", ((g.FullName ?? "Без Названия") + g.Filled.ToString()).Replace(" ", "") + ".xlsx");
        }
    }
}
