using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusBase.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MusBase.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public string Index()
        {
            return "Index";
        }

        // GET: /Home/Info/
        public string Info()
        {
            return "Info";
        }
    }
}
