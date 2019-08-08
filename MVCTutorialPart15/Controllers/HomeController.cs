using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorialPart15.Models;

namespace MVCTutorialPart15.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.MyCustomProperty = "Neitzshe";
            ViewBag.MyList = new List<string>() {"Romulus", "Remus", "Peter"};
            List<Employee> MyEmployeeList = new List<Employee>();
            Employee employee1 = new Employee() { Id = 1, Name = "Vasil", Email = "gmail" };
            Employee employee2 = new Employee() { Id = 2, Name = "Lile", Email = "yahoo" };
            MyEmployeeList.Add(employee1);
            MyEmployeeList.Add(employee2);
            ViewBag.EmployeeList = MyEmployeeList;
            return View();
        }
        public ActionResult Demo() {
            ViewData["myKey"] = "This is the value for my key";
            ViewData["myList"] = new List<string>() { "Romulus", "Remus", "Peter" };
            return View();
        }
    }
}