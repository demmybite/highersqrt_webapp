using Microsoft.AspNetCore.Mvc;
using System;
namespace SquareRootApp.Controllers
{
    public class SquareRootController : Controller
    {


        [HttpGet]
        public ActionResult HigherSqrt()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HigherSqrt(string firstnumber, string secondnumber)
        {
            int firstentry = 0;
            int secondentry = 0;
            firstentry = int.Parse(firstnumber);
            secondentry = int.Parse(secondnumber);
            double firstentrySqrt = Math.Sqrt(firstentry);
            double secondentrySqrt = Math.Sqrt(secondentry);
            ViewBag.firstentry = firstentry;
            ViewBag.secondentry = secondentry;
            ViewBag.firstentry_ = firstentrySqrt;
            ViewBag.secondentry_ = secondentrySqrt;
            return View();
        }

    }
}