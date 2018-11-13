﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Submitform(string name, string age, HttpPostedFileBase file)
        {
            if (file != null)
            {
                string filename = file.FileName;
                string exname = System.IO.Path.GetExtension(filename);
                string savepath = Server.MapPath(string.Format("~/Content/img/{0}", filename));
                file.SaveAs(savepath);
            }

            if (Request.Files.Count > 0)
            {
                var myFile = Request.Files["file"];
                myFile.SaveAs(Server.MapPath("~/upload/")+myFile.FileName);
            }
            return Json("1");
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