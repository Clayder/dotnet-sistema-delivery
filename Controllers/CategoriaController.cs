using dotnet_sistema_delivery.Data;
using dotnet_sistema_delivery.DTO;
using dotnet_sistema_delivery.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace dotnet_sistema_delivery.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ApplicationDbContext database;

        public CategoriaController(ApplicationDbContext database){
            this.database = database;
        }
        
        [HttpPost]
        public IActionResult Salvar(CategoryDTO category){
            if(ModelState.IsValid){
            
                Category newCategory = new Category();
                newCategory.name   = category.name;
                newCategory.status = true;

                database.category.Add(newCategory);
                database.SaveChanges();
                
                return RedirectToAction("Categorias", "Admin");
            }else{
                return View("../Admin/NovaCategoria");
            }
        }
    }
}