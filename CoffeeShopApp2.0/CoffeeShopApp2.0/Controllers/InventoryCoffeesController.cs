using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CoffeeShopApp2._0.DALdata;
using CoffeeShopApp2._0.Models;

namespace CoffeeShopApp2._0.Controllers
{
    public class InventoryCoffeesController : Controller
    {
        private CoffeeShopContext db = new CoffeeShopContext();

        // GET: InventoryCoffees
        public ActionResult Index()
        {
            return View(db.InventoryCoffees.ToList());
        }

        // GET: InventoryCoffees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventoryCoffee inventoryCoffee = db.InventoryCoffees.Find(id);
            if (inventoryCoffee == null)
            {
                return HttpNotFound();
            }
            return View(inventoryCoffee);
        }

        // GET: InventoryCoffees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InventoryCoffees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Description,Quantity,Price")] InventoryCoffee inventoryCoffee)
        {
            if (ModelState.IsValid)
            {
                db.InventoryCoffees.Add(inventoryCoffee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(inventoryCoffee);
        }

        // GET: InventoryCoffees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventoryCoffee inventoryCoffee = db.InventoryCoffees.Find(id);
            if (inventoryCoffee == null)
            {
                return HttpNotFound();
            }
            return View(inventoryCoffee);
        }

        // POST: InventoryCoffees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Description,Quantity,Price")] InventoryCoffee inventoryCoffee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inventoryCoffee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inventoryCoffee);
        }

        // GET: InventoryCoffees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventoryCoffee inventoryCoffee = db.InventoryCoffees.Find(id);
            if (inventoryCoffee == null)
            {
                return HttpNotFound();
            }
            return View(inventoryCoffee);
        }

        // POST: InventoryCoffees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InventoryCoffee inventoryCoffee = db.InventoryCoffees.Find(id);
            db.InventoryCoffees.Remove(inventoryCoffee);
            db.SaveChanges();
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
    }
}
