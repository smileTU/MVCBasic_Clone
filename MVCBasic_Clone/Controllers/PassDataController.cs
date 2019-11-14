using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasic_Clone.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PassViewData()
        {
            ViewData["Name"] = "Kevin";  //存字串
            ViewData["Age"] = 33;        //存數字
            ViewData["Single"] = true;   //存布林
            return View();
        }

        public ActionResult PassViewBag()
        {
            ViewBag.Nickname = "Mary";
            ViewData["Nickname"] = "David";
            ViewBag.Height = 168;
            ViewBag.weight = 52;
            ViewBag.Married = false;
            return View();
        }

        public ActionResult PetShop()
        {
            ViewData["Company"] = "汪星人寵物店";

            ViewBag.Address = "台北市信義區松山路100號";

            List<string> petList = new List<string>();
            petList.Add("狗");
            petList.Add("貓");
            petList.Add("魚");
            petList.Add("鼠");
            petList.Add("變色龍");

            ViewData.Model = petList;
            return View();

        } 

        public ActionResult PassTempData()
        {
            TempData["ErrorMessage"] = "權限不足，無法存取，請聯絡系統管理員";
            TempData["UserName"] = "David";
            TempData["Time"] = DateTime.Now.ToLongTimeString();

            return RedirectToAction("ErrorMessage", "ErrorHandler");
        }
    }
}