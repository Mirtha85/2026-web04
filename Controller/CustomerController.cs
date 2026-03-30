using Microsoft.AspNetCore.Mvc;
using NakamaShop.Models;

namespace NakamaShop.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _repo;

        public CustomerController(ICustomerRepository repo)
        {
            _repo = repo;
        }

      
        public IActionResult Register() => View();

     
        [HttpPost]
        public IActionResult Register(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _repo.CreateCustomer(customer); // Llama al guardado
                
                ViewBag.Message = "¡REGISTRO EXITOSO EN LA BD!";
                
                ModelState.Clear(); // Limpia los cuadros de texto
                return View(new Customer()); 
            }
            return View(customer);
        }
    }
}