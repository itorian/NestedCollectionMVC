using NestedCollectionModelMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NestedCollectionModelMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(bool? success)
        {

            if(success == true)
            {
                ViewBag.Message = "Record added";
            }

            if(success == false)
            {
                ViewBag.Message = "Failed to add record";
            }

            var employee = new Employee();
            employee.CreatePhoneNumbers(2);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Index(Employee employee)
        {


            return Redirect("~/home/index?success=true");
        }
    }
}