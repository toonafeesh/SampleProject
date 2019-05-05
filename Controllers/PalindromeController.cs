using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleApplication.Models;

namespace SampleApplication.Controllers
{
    public class PalindromeController : Controller
    {
        // GET: Palindrome
        public ActionResult Index()
        {
            PalindromeViewModel pvm = new PalindromeViewModel();
            ViewBag.ShowPalindromeMessage = false;
            return View(pvm);
        }

        [HttpPost]
        public ActionResult Index(PalindromeViewModel pvm)
        {
            // Verify positive number, add error if invalid
            if (pvm.Number < 1)
                ModelState.AddModelError("Number", "Submitted number must be a positive number.");

            // If Model is invalid, return with errors
            if (!ModelState.IsValid)
                return View(pvm);

            // Convert number to string, char array, reverse and convert back to an int
            var charArray = pvm.Number.ToString().ToCharArray();
            Array.Reverse(charArray);
            var reverseNumber = Convert.ToInt32(new String(charArray));

            // Check if number and reversed number are the same, if they are, the number is a palindrome
            if (pvm.Number == reverseNumber)
                pvm.IsPalindrome = true;

            ViewBag.ShowPalindromeMessage = true;
            return View(pvm);
        }
    }
}