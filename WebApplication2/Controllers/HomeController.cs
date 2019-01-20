using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebModels;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
         
            return View();
        }
        [HttpPost]
        public string Submitform(User user)
        {
            //if (file != null)
            //{
            //    string filename = file.FileName;
            //    string exname = System.IO.Path.GetExtension(filename);
            //    string savepath = Server.MapPath(string.Format("~/Content/img/{0}", filename));
            //    file.SaveAs(savepath);
            //}

            //if (Request.Files.Count > 0)
            //{
            //    var myFile = Request.Files["file"];
            //    myFile.SaveAs(Server.MapPath("~/upload/")+myFile.FileName);
            //}

            return WebDal.BaseDal.UpdateUser(user);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public string GetData()
        {
            string re = Guid.NewGuid().ToString();
            return re;
        }
        public ActionResult Contact()
        {
            
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult multiselect()
        {
            return View();
        }
        public string GetName(int input)
        {
            string re = "";
            switch (input)
            {
                case 0:
                    re="jack";
                    break;
                case 1:
                    re="jim";
                    break;
                case 2:
                    re = "jon";
                    break;
                case 3:
                    re = "kloye";
                    break;
            }
            return re;
        }
    }
}