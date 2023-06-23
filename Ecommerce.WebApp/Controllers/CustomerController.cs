using Ecommerce.Models.EntityModels;
using Ecommerce.Repositories;
using Ecommerce.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebApp.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepository _customerRepository;

        public CustomerController()
        {
            _customerRepository = new CustomerRepository();
        }
        public IActionResult Index()
        {
            return View();
        }

        public string List()
        {
            return "This is a customer list";
        }

       
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CustomerCreate model)
        {

            if (ModelState.IsValid)
            {
                var customer = new Customer()
                {
                    Name = model.Name,
                    Phone = model.Phone,
                    Email = model.Email,
                };
                //Database operations 
                bool isSuccess = _customerRepository.Add(customer);

                if (isSuccess)
                {
                    return View();
                }
               
            }
            
            return View();


          



          
        }
    }
}
