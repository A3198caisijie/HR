using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using IBLL;
using EFEntity;
using Newtonsoft.Json;

namespace HR.Controllers
{
    public class LoginController : Controller
    {
        public UsersIBLL Uib { get; set; }
        // GET: Login
        [HttpPost]
        public ActionResult Login(UsersModel us)
        {
            List<UsersModel> list= Uib.UsersSelect().Where(a => a.user_name == us.user_name&&a.u_password==us.u_password).ToList();
            if (list.Count > 0)
            {
                Session["user_name"] = list[0].user_name;
                return Content("<script>alert('登录成功');window.location.href='/salaryCriterion/salarystandard_register';</script>");
            }
            else
            {
                return Content("<script>alert('登录失败');window.location.href='/Login/Login';</script>");
            }
            
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
    }
}