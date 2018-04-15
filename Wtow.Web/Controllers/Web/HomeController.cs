using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wtow.Data;
using Wtow.Domain;
using Wtow.Service;
using Wtow.Web.Models;

namespace Wtow.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITitleService _titleService;

        public HomeController(ITitleService titleService)
        {
            _titleService = titleService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllTitles()
        {
            return Ok();

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
