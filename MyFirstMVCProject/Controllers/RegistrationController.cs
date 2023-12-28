using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstMVCProject.Models;

namespace MyFirstMVCProject.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveRegistration(RegistrationModel model)
        {
            try
            {
                // data comes in this model in the json format.returns message.

                return Json(new { Message = (new RegistrationModel().SaveRegistration(model)) },

                JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}