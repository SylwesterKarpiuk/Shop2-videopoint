using Shop2_videopoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop2_videopoint.Controllers
{
    [Authorize]
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
                model.Name = User.Identity.Name;
                _db.Review.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = model.ProductId });
            }
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var review = _db.Review.Find(id);
            if (review.Name == User.Identity.Name)
            {
                if (review != null)
                {
                    return View(review);
                }
            }
            
            return RedirectToAction("Index","Products");
            
        }
        [HttpPost]
        public ActionResult Edit(Review model)
        {
            if (model.Name == User.Identity.Name)
            {
                if (ModelState.IsValid)
                {
                    _db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    _db.SaveChanges();
                    return RedirectToAction("Index", new { id = model.ProductId });
                }
            }
            return View(model);
        }
    }
}