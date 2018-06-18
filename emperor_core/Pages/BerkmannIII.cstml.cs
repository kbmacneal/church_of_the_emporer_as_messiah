using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using church_of_the_emporer_as_messiah.Sermons;
using System.Web;
using Microsoft.AspNetCore.Hosting;

namespace church_of_the_emporer_as_messiah.Pages
{
    public class CathedralModel : PageModel
    {
        public string cathedraltext { get; set; }

        public void OnGet()
        {
            setContent();
        }

        protected void setContent()
        {
            var filename = "wwwroot/Documents/berkmann_opening.md";
            
            cathedraltext = cls_markdown.ConvertMDtoTXT(filename);
            
        }
    }
}