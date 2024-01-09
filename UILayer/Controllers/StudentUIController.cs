using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UILayer.Controllers
{
    public class StudentUIController : Controller
    {
        // GET: StudentUI
        public ActionResult AddStudent()
        {
            return View();
        }
    }
}