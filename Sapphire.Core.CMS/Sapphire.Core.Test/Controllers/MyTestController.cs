using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sapphire.Core.Test.Controllers
{
    public class MyTestController : TestBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}