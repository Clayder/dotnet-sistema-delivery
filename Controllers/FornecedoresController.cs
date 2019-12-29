using dotnet_sistema_delivery.Data;
using dotnet_sistema_delivery.DTO;
using dotnet_sistema_delivery.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace dotnet_sistema_delivery.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly ApplicationDbContext database;

        public FornecedoresController(ApplicationDbContext database){
            this.database = database;
        }
        
        [HttpPost]
        public IActionResult Salvar(SupplierDTO supplier){
            if(ModelState.IsValid){
            
                Supplier newSupplier = new Supplier();

                newSupplier.name      =  supplier.name ;
                newSupplier.email     =  supplier.email ;
                newSupplier.telephone =  supplier.telephone ;
                newSupplier.status    =  true;
            
                database.supplier.Add(newSupplier);
                database.SaveChanges();
                
                return RedirectToAction("Fornecedores", "Admin");
            }else{
                return View("../Admin/NovoFornecedor");
            }
        }
    }
}