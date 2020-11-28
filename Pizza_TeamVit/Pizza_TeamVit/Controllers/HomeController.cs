using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizza_TeamVit.Models;

namespace Pizza_TeamVit.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index() => View();


    }
}
