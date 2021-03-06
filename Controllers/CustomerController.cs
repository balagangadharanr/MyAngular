﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyAngular8_2.Models;

namespace MyAngular8_2.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("[action]")]
        public IEnumerable<Customer> GetCustomers()
        {
            IList<Customer> customers = new List<Customer>
            {
                new Customer { CustomerName = "Vasigaran", CustomerPhone = "9535447447", CustomerEmail = "Vasigaran@gmail.com"},
                new Customer { CustomerName = "adsss", CustomerPhone = "9535447447", CustomerEmail = "Vasigaran@gmail.com"},
                new Customer { CustomerName = "Vasigaran", CustomerPhone = "9535447447", CustomerEmail = "Vasigaran@gmail.com"},
            };

            return customers;
        }
		
		public IEnumerable<Customer> GetCustomers()
        {
            IList<Customer> customers = new List<Customer>
            {
                new Customer { CustomerName = "Vasigaran", CustomerPhone = "9535447447", CustomerEmail = "Vasigaran@gmail.com"},
                new Customer { CustomerName = "adsss", CustomerPhone = "9535447447", CustomerEmail = "Vasigaran@gmail.com"},
            };

            return customers;
        }
    }
}
