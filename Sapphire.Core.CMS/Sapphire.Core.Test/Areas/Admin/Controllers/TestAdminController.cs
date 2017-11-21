using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sapphire.Core.Test.Areas.Admin.Controllers
{
    [Area("Test")]
    [Route("manage/[area]/[controller]/[action]")]
    public class TestAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}