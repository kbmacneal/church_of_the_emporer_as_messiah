using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using emperor_mvc.Models;
using emperor_mvc.Classes;
using System.IO;

namespace emperor_mvc.Controllers
{
    public class PDFController : Controller
    {
        public IActionResult Charity(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/ninth_virtue_charity.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Faith(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/faith_and_virtue.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Teuthem(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/Teuthem_Memoriam.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Debate(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/12th_debate_response.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Excom(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/Excommunication.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Koschei(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/koschei_1.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Berkmann(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/berkmann_iii_pr.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Unity(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/spirit_of_unity.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Questions(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/20questions.pdf";
            model.set_html();
            return View("Index", model);
        }
    }
}