using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace emperor_mvc.Models {
    public class SermonYakiyahModel {
        public string sermonheader {
            get;
            set;
        }
        public string sermonheaderright {
            get;
            set;
        }
        public string sermontext { get; set; }

        public string sermontextright { get; set; }
    }
}