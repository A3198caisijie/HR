using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using Model;
using Newtonsoft.Json;

namespace HR.Controllers
{
    public class salaryCriterionController : Controller
    {
        public Salary_standardIBLL ssib { get; set; }

        // GET: salaryCriterion
        public ActionResult salarystandard_register()
        {
            //List<Salary_grantModel> list = new List<Salary_grantModel>();
            //ViewData.Model = list;
            //return Content(JsonConvert.SerializeObject(list));
            return View();
        }
    }
}