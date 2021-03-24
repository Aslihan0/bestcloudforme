using BestCloudApi.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BestCloudApi.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            //ViewBag.Title = "Home Page";

            //return View();
            Person p = new Person();
            p.firstName = "Aslıhan";
            p.lastName = "Sönmez";
            string json = JsonConvert.SerializeObject(p);
            return json;
        }
    }
}
