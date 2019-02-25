using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBasics.Pages
{
    [BindProperties]
    public class calculatorModel : PageModel
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public string ans { get; set; }

        public void OnGet()
        {
        }

        public void OnPostAdd()
        {
            ans = num1 + " + " + num2 + " = " + (num1 + num2);
        }
        public void OnPostSubtract()
        {
            ans = num1 + " - " + num2 + " = " + (num1 - num2);
        }
        public void OnPostMultiply()
        {
            ans = num1 + " * " + num2 + " = " + (num1 * num2);
        }
        public void OnPostDivide()
        {
            ans = num1 + " / " + num2 + " = " + (num1 / num2);
        }
    }
}