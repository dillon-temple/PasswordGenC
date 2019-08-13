using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PasswordGen.Models;
using System.Text;

namespace PasswordGen.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder result = new StringBuilder();
            Random random = new Random();

            int i = 0;
            while (i < 14)
            {
                result.Append(characters[random.Next(0, characters.Length)]);
                i++;
            }
            ViewBag.result = result;
            return View();
        }
    }
}
