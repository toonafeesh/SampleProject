using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleApplication.Models
{
    public class PalindromeViewModel
    {
        public bool IsPalindrome { get; set; }
        [Required]
        [Display(Name = "Number to Check")]
        public int Number { get; set; }

        public PalindromeViewModel()
        {
            IsPalindrome = false;
            Number = 0;
        }
    }
}