using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _Context;

        public CustomersController()
        {
            _Context = new ApplicationDbContext();    
        }

        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _Context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _Context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }

        public ActionResult New()
        {
            var membershipTypes = _Context.MembershipTypes.ToList();

            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm",viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _Context.MembershipTypes.ToList()
                };

                return View("CustomerForm", viewModel);
            }

            if (customer.Id == 0)
            {
                _Context.Customers.Add(customer);
            }
            else
            {
                var customerInDB = _Context.Customers.Single(c => c.Id == customer.Id);
                customerInDB.Name = customer.Name;
                customerInDB.Birthdate = customer.Birthdate;
                customerInDB.MembershipTypeId = customer.MembershipTypeId;
                customerInDB.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }
            _Context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _Context.Customers.SingleOrDefault(c => c.Id == id);

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _Context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }
    }
}