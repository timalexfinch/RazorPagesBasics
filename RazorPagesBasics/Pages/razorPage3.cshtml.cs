using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBasics.Pages
{
    public class razorPage3Model : PageModel
    {
        public string prop1 { get; private set; } 
        public string prop2 { get; private set; }            

        public void OnGet()
        {
            prop1 = "I’m Property One!";
            prop2 = $" The time on the Server is: { DateTime.Now.ToLongTimeString()}";
        }
    }
}