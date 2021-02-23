using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Controllers
{
    public class Assignment : Controller
    {
        [Route("{Controller}/[action]/{id?}")]
        public IActionResult AccessLevel(int id = 1)
        {
            ViewBag.ID = id;
            return View();
        }
    }
}
