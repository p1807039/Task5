﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AmazonS3Uploader amazonS3 = new AmazonS3Uploader();

            amazonS3.UploadFile();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}