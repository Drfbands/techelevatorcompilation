using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Web.DAL;
using Post.Web.Models;

namespace Post.Web.Controllers
{
    public class HomeController : Controller
    {


        private IReviewDAO reviewDAO;
        public HomeController(IReviewDAO reviewDAO)
        {
            this.reviewDAO = reviewDAO;
        }
        public IActionResult Index()
        {
            var reviews = reviewDAO.GetAllReviews();
            return View(reviews);
        }

        [HttpGet]
        public IActionResult NewReview()
        {
            Review review = new Review();
            return View(review);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewReview(Review review)
        {
            reviewDAO.SaveReview(review);

            return RedirectToAction("Index");
        }
    }
}
