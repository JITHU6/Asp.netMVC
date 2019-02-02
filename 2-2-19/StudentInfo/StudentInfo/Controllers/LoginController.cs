using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentInfo.Models;
using StudentInfo.viewstud;

namespace StudentInfo.Controllers
{
    public class LoginController : Controller
    {
        public UserContext db = new UserContext();
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(login lm)
        {
            var a = db.registrations.Where(x => x.name == lm.username & x.sname == lm.password).FirstOrDefault();
            if(a == null)
            {
                ModelState.AddModelError("","invalid username &password");
                return View();
            }

            return RedirectToAction("Index", "Addmarks");
        }

    }
}
