using Microsoft.AspNetCore.Mvc;
using System;

namespace dotnet_sistema_delivery.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}