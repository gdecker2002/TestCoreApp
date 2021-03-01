using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;

namespace CIS174_TestCoreApp.Controllers
{
    public class Assignment : Controller
    {
        [Route("Assignment/{id?}")]
        public IActionResult AccessLevel(int id = 1)
        {
            ViewBag.Assignmentid = id;

            List<Student> studentDetails = new List<Student>();
            studentDetails.Add(new Student("Bobby", "Bobberson", "A"));
            studentDetails.Add(new Student("Muk", "Yellow", "A-"));
            studentDetails.Add(new Student("Jack", "Peterson", "F"));
            studentDetails.Add(new Student("Peter", "Hare", "C"));
            studentDetails.Add(new Student("Jimmy", "Timmy", "B+"));

            return View("AccessLevel", studentDetails);
        }
    }
}
