using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Randam_Name.Controllers
{
    public class ResultController : Controller
    {
        [HttpPost]
        public IActionResult created()
        {
            string format = Request.Form["format"];
            int name_length = int.Parse(Request.Form["number"]);

            name_create name_creater = new name_create();
            ViewData["name_result"] = name_creater.output_name(format,name_length);

            return View("result");
        }
    }
}