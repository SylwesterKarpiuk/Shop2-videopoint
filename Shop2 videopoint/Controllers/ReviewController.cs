using Shop2_videopoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop2_videopoint.Controllers
{
    public class ReviewController : BaseController
    {
        // GET: Review
        public ActionResult Index([Bind(Prefix="id")]int productId)
        {
            var product = _db.Products.Find(productId);
            if (product!=null)
            {
                return View(product);
            }
            return HttpNotFound();
        }
        public ActionResult Create(int productId)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Review model)
        {
            if (ModelState.IsValid)
            {
                _db.Review.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = model.ProductId });
            }
            return View(model);
        }
    }
}