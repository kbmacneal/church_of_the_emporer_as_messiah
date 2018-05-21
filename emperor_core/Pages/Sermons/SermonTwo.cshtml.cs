﻿using System;
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
    public class SermonTwo : PageModel
    {
        public string sermonheader { get; set; }
        public string sermontext { get; set; }
        private IHostingEnvironment _env;

        public void OnGet()
        {
            setContent();
        }

        protected void setContent()
        {
            var filename = "wwwroot/Sermons/SermonTwo.md";

            sermonheader = "";
            sermontext = cls_markdown.ConvertMDtoTXT(filename);
            
        }
    }
}