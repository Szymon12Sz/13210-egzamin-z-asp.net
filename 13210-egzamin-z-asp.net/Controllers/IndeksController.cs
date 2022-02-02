using _13210_egzamin_z_asp.net.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13210_egzamin_z_asp.net.Controllers
{
    public class IndeksController : Controller
    {
        static List<StudentsGrades> studentsGrades = new List<StudentsGrades>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(StudentsGrades _studentsGrades)
        {
            if (ModelState.IsValid)
            {
                studentsGrades.Add(_studentsGrades);
                return View("List", studentsGrades);
            }
            else
            {
                return View(_studentsGrades);
            }
        }


    }
}
