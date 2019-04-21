using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RecruitManage.Controllers
{
    public class AuthenticateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}