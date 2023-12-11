using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEMPM.Controllers
{
    public class WorkHistoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
