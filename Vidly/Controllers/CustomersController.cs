using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        [Route("customers/customers")]
        public ActionResult Customers()
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Customer 1"},
                new Customer {Id = 2, Name = "Customer 2"}
            };

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }

        [Route("customers/customerdetails/{id}")]
        public ActionResult CustomerDetails(int id)
        {
            var customer = new Customer { Id = id, Name = "Customer " + id };
      
            var viewModel = new CustomerDetailsViewModel
            {
                SelectedCustomer = customer
            };
            return View(viewModel);
        }
    }
}