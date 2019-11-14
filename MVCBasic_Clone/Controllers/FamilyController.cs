using MVCBasic_Clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasic_Clone.Controllers
{
    public class FamilyController : Controller
    {
        // GET: Family
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FamilyList()
        {
            List<Family> family = new List<Family>()
            {
                new Family{ ID="F123456789", Name="test01",Phone="0912-345-678",Age=18,City="台北市"},
                new Family{ ID="A223456789", Name="test02",Phone="0922-345-678",Age=28,City="新北市"},
                new Family{ ID="G323456789", Name="test03",Phone="0932-345-678",Age=38,City="宜蘭市"}
            };
            return View(family);
        }
    }
}