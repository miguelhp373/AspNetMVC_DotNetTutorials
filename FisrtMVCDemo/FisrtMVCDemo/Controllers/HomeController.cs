using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FisrtMVCDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index(string id)
        {
            return "This Id =>" + id + " | Search Text: " + Request.QueryString["search"];
        }
    }
}