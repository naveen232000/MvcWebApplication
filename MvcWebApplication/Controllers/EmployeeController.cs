using MvcWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        static List<Employee> employees = new List<Employee>() {
            new Employee{Id=1,Name="Sam",Designation="Developer",Salary=22345,Doj=new DateTime(day:12,month:12,year:2023)},
             new Employee{Id=2,Name="Ram",Designation="Tester",Salary=15345,Doj=new DateTime(day:13,month:11,year:2022)},
              new Employee{Id=3,Name="Jon",Designation="Hr",Salary=20000,Doj=new DateTime(day:23,month:10,year:2021)},
               new Employee{Id=4,Name="Davi",Designation="Manager",Salary=34345,Doj=new DateTime(day:15,month:09,year:2022)},
                new Employee{Id=5,Name="Kumar",Designation="Trainee",Salary=12345,Doj=new DateTime(day:10,month:11,year:2020)},
                 new Employee{Id=6,Name="Naveen",Designation="Developer",Salary=22705,Doj=new DateTime(day:19,month:09,year:2023)},
            };
        public ActionResult Index()
        {
            return View(employees);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Employee());
        }
        [HttpPost]
        public ActionResult Create(Employee emp) {
            if (ModelState.IsValid)
            {
                employees.Add(emp);
                return RedirectToAction("Index");
            }
            return View(emp);
        }
    }
}