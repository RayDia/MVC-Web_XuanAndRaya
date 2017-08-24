using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _28199014_MVC.Models;

namespace _28199014_MVC.Controllers
{
    public class OrdersController : Controller
    {
        private Entities db = new Entities();

        // GET: Orders
        public ActionResult Index()
        {
            var order = db.Order.Include(o => o.Cat).Include(o => o.User);
            return View(order.ToList());
        }

        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Order.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            ViewBag.ordercid = new SelectList(db.Cat, "cid", "breed");
            ViewBag.orderuid = new SelectList(db.User, "Id", "username");
            return View();
        }

        // POST: Orders/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "oid,orderData,orderDescription,orderuid,ordercid")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Order.Add(order);
                db.SaveChanges();
                return RedirectToAction("SearchIndex");
            }

            ViewBag.ordercid = new SelectList(db.Cat, "cid", "breed", order.ordercid);
            ViewBag.orderuid = new SelectList(db.User, "Id", "username", order.orderuid);
            return View(order);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Order.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.ordercid = new SelectList(db.Cat, "cid", "breed", order.ordercid);
            ViewBag.orderuid = new SelectList(db.User, "Id", "username", order.orderuid);
            return View(order);
        }

        // POST: Orders/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "oid,orderData,orderDescription,orderuid,ordercid")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("SearchIndex");
            }
            ViewBag.ordercid = new SelectList(db.Cat, "cid", "breed", order.ordercid);
            ViewBag.orderuid = new SelectList(db.User, "Id", "username", order.orderuid);
            return View(order);
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Order.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = db.Order.Find(id);
            db.Order.Remove(order);
            db.SaveChanges();
            return RedirectToAction("SearchIndex");
        }

        // Search Orders 
        public ActionResult SearchIndex(string searchValue)
        {
            var orders = from m in db.Order

                       select m;
            if (string.IsNullOrEmpty(searchValue) == false)
            {
                orders = orders.Where(m => m.orderDescription.Contains(searchValue));
            }
            return View(orders);
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
