
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Classes;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace emperor_mvc.Controllers {
    public class DenunciationController : Controller {

        [HttpGet]
        public ActionResult Index () {

            return View ();
        }

        public IActionResult Justice(DenunciationModel model)
        {
            model.link = "https://highchurch.space/Documents/Denunciation/Justice.pdf";
            model.set_html();
            return View("Denunciation", model);
        }
    }
}