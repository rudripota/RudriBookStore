using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RudriBookStore.Areas.Admin.Controllers
{
    public class CoverType : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
