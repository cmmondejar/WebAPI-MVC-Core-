using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPPMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPPMVC.Controllers
{
    public class LoginController : Controller
    {
        //EmployeeDAL employeeDAL = new EmployeeDAL();
        DBUser dbo = new DBUser();
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([Bind] UserLogin user)
        {
            string res = dbo.LoginCheck(user);
            if (res == "Admin")
            {
                TempData["msg"] = "Welcome ADMIN SECTION PAGE";
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            else
            {
                TempData["msg"] = "Welcome STAFF SECTION PAGE";
                return RedirectToAction("Index1", "Home", new { area = "" });
            }
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult userLogin([Bind] UserInfo objEmp)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        employeeDAL.Userlogin(objEmp);
        //        return RedirectToAction("Index");
        //    }
        //    return View(objEmp);
        //}
    }
}