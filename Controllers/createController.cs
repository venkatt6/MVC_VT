using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_VT.Models;

namespace MVC_VT.Controllers
{
    public class createController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(createUser user)
        {
            //var user = new User();            
            return View(user);
        }
    }
}
