using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBasics.Pages
{
    [BindProperties]
    public class sayHelloModel : PageModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
    }
}