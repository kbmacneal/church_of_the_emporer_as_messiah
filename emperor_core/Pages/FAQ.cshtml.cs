using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace church_of_the_emporer_as_messiah.Pages
{
    public class FAQ : PageModel
    {
        public string FAQcontent{get;set;}
        public void OnGet()
        {

        }
    }
}