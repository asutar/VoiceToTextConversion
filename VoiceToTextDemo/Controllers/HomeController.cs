using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VoiceToTextDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdvIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProcessVoiceInput(string voiceText)
        {
            // Process the voiceText as needed (e.g., save to database or process further)
            // For demonstration, we’ll just send it back as a response
            return Json(new { success = true, text = voiceText });
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}