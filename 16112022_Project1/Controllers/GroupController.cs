using _16112022_Project1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _16112022_Project1.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.Groups);
        }

        public IActionResult Detail(int id)
        {
            Group group = Data.Groups.Find(x => x.Id == id);

            return View(group);
        }
    }
}
