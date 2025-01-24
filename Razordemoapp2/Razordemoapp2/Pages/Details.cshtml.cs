using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razordemoapp2.ViewModel;

namespace Razordemoapp2.Pages
{
    public class DetailsModel : PageModel
    {
        public  Person person { get; set; }
        public void OnGet()
        {
            person = new Person() { Id = 1, Name = "Sandeep soni" };
            

        }
    }
}