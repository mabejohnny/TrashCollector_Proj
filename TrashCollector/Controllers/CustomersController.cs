using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomersController
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            
            if(customer == null)
            {
                return RedirectToAction("Create");
            }
            else
            {
                return View(customer);
            }
        }

        // GET: CustomersController/Details/5
        public ActionResult Details(int? id)
        {
           

            if(id = null)
            {
                return NotFound();
            }
            return View(customersInDatabase);
        }

        // GET: CustomersController/Create
        public ActionResult Create()
        {
            Customer customer = new Customer();
            return View(customer);
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if(ModelState.IsValid)
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
              return View(customer);
            
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(int id)
        {
            var customerToEdit = _context.Customers.Where(c => c.Id == id).Single();
            if(customerToEdit == null)
            {
                return NotFound();
            }
            return View(customerToEdit);
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                _context.Customers.Update(customer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: CustomersController/Delete/5
        public ActionResult Delete(int id)
        {
            var customertoDelete = _context.Customers.Where(c => c.Id == id).SingleOrDefault();

            if(customertoDelete == null)
            {
                return NotFound();
            }
            return View(customertoDelete);

        } 

        // POST: CustomersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Customer customer)
        {
            try
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }
        }

       public ActionResult SetPickupDay(Customer customer)
       {
            try
            {
                _context.Customers.Update(customer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
            
       }
       
        public ActionResult TemporaryStartOrStopService(Customer customer)
        {
            try
            {
                _context.Customers.Update(customer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }

        }

        public ActionResult ExtraOneTimePickup(Customer customer)
        {
            try
            {
                _context.Customers.Update(customer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }

        }







    }
}
