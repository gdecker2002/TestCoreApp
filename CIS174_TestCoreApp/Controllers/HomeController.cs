using Microsoft.AspNetCore.Mvc;
using CIS174_TestCoreApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace CIS174_TestCoreApp.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            return View();
        }

    }
}
