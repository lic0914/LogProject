using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LogProject.Models;

namespace LogProject.Controllers
{
    public class HomeController : Controller
    {
        private LogContext _context;
        public HomeController(LogContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            var logs=_context.Logs.OrderByDescending(e=>e.Id).Take(20).ToArray();
            return View(logs);
        }
        public IActionResult ExceptionInfo(int id)
        {
           
            var log=_context.Logs.SingleOrDefault(e=>e.Id==id);
            return View(log);
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

      
    }
}
