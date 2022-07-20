using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFirstProject.Models;

namespace MVCFirstProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Employeeinfo()
        {

            Employee employee = new Employee()
            {
                Employeeld = 1001,
                EmployeeName = "Khaja Moiz",
                EmployeeLocation = "Hyderabad"
            };

            return View(employee);
        }
    }
}