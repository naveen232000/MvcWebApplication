﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Help()
        {
            return View();
        }
        public string Welcome()
        {
            return "<h1>Welcome to Student</h1><br><p> - returning string </p>";
        }
    }
}