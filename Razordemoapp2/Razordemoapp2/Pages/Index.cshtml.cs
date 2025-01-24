using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razordemoapp2.Pages
{
    public class IndexModel : PageModel
    {

        public string Message { get; set; } = "  Hello Asp .net Core"+DateTime.Now.ToLongDateString(); 
        public void OnGet()
        {
            Message= "  Hello Asp .net Core" + DateTime.Now.ToLongDateString(); 

        }
    }
}
