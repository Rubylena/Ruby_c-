using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
        public class RootController : Controller
        {
            // public double root {get; set;}

            [HttpGet]
            public ActionResult Sqrroot()
        {
            return View();
        }

            [HttpPost]
            public ActionResult Sqrroot(string firstNumber, string secondNumber)
        {
            double one = int.Parse(firstNumber);
            double two = int.Parse(secondNumber);
            
            ViewBag.One = one;
            ViewBag.Two = two;

            double root1 = Math.Sqrt(one);
            double root2 = Math.Sqrt(two);
        
            ViewBag.Root1 = root1;
            ViewBag.Root2 = root2;
            return View();
        }

        }

}