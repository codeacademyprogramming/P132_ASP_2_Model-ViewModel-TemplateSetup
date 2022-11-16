using _16112022_Project1.Models;
using _16112022_Project1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _16112022_Project1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = Data.Students;
            List<Group> groups = Data.Groups;

            StudentViewModel stdVM = new StudentViewModel
            {
                Groups = groups,
                Students = students
            };


            return View(stdVM);
        }

        public IActionResult Detail(int id)
        {
            //ViewBag.Id = id;
            //ViewBag.Name = name;

            Student std = Data.Students.Find(x => x.Id == id);

            //ViewBag.Student = std;

            return View(std);
        }

        //public IActionResult ShowDetail(int id)
        //{
        //    ViewBag.Id = id;
        //    TempData["Id"] = id;

        //    return RedirectToAction("detail");
        //}
    }
}
