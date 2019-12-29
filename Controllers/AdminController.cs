using Microsoft.AspNetCore.Mvc;
using System;

namespace dotnet_sistema_delivery.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index(){
            return View();
        }

        public IActionResult Categorias(){
            return View();
        }

        public IActionResult NovaCategoria(){
            return View();
        }

        public IActionResult Fornecedores(){
            return View();
        } 

        public IActionResult NovoFornecedor(){
            return View();
        } 
    }
}