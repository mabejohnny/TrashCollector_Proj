using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Exchange.WebServices.Data;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    [Authorize(Roles = "Employee")]
    public class EmployeesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EmployeesController/Index/5
        public ActionResult Index()
        {
            var employeeId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employeeOne = _context.Employees.Where(c => c.IdentityUserId == employeeId).FirstOrDefault();

            var today = DateTime.Now.DayOfWeek.ToString();
            DateTime todaysDate = DateTime.Now;
            var customersInArea = _context.Customers.Where(c => c.ZipCode == employeeOne.ZipCode && c.PickupDayChoice == today).ToList();

            List<Customer> customerStops = new List<Customer>();

            foreach (var customer in customersInArea)
            {
                if (customer.PickedUp == false)
                {
                    customerStops.Add(customer);
                }
            }
            return View(customerStops);
        }

        // GET: EmployeesController/CustomerMapDetails/5
        public ActionResult CustomerMapDetails(int id)
        {
            ViewData["GOOGLE_API_KEY"] = APIkeys.GOOGLE_API_KEY;
            var customerToView = _context.Customers.Where(c => c.Id == id).SingleOrDefault();
            return View(customerToView);
        }

        // GET: EmployeesController/PopulateWeeklyList
        public ActionResult PopulateWeeklyList(int id, Employee employee)
        {
            var employeeId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employeeOne = _context.Employees.Where(c => c.IdentityUserId == employeeId).FirstOrDefault();
            var customersInArea = _context.Customers.Where(c => c.ZipCode == employeeOne.ZipCode).ToList();

            return View();
        }
        // POST: EmployeesController/PopulateWeeklyList
        public ActionResult PopulateWeeklyList(Employee employee, string DayChoice)
        {
            switch (DayChoice)
            {
                case "1":
                    List<Customer> monday = _context.Customers.Where(c => c.ZipCode == employee.ZipCode && c.PickupDayChoice == "Monday").ToList();
                    return View(monday);
                case "2":
                    List<Customer> tuesday = _context.Customers.Where(c => c.ZipCode == employee.ZipCode && c.PickupDayChoice == "Tuesday").ToList();
                    return View(tuesday);
                case "3":
                    List<Customer> wednesday = _context.Customers.Where(c => c.ZipCode == employee.ZipCode && c.PickupDayChoice == "Wednesday").ToList();
                    return View(wednesday);
                case "4":
                    List<Customer> thursday = _context.Customers.Where(c => c.ZipCode == employee.ZipCode && c.PickupDayChoice == "Thursday").ToList();
                    return View(thursday);
                case "5":
                    List<Customer> friday = _context.Customers.Where(c => c.ZipCode == employee.ZipCode && c.PickupDayChoice == "Friday").ToList();
                    return View(friday);
                default:
                    return NotFound();
            }
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
          return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee.IdentityUserId = userId;
                _context.Add(employee);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }  
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int? id)
        {
            var employee = _context.Employees.Where(c => c.Id == id).SingleOrDefault();
            if ( id == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee employee)
        {
            try
            {
                _context.Update(employee);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int? id)
        {
            var employeeToDelete = _context.Employees.Where(c => c.Id == id).SingleOrDefault();

            if (employeeToDelete == null)
            {
                return NotFound();
            }
            if (id == null)
            {
                return NotFound();
            }
            return View(employeeToDelete);
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Employee employee)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult PickedUp(int id)
        {
            var customer = _context.Customers.Find(id);
            customer.PickedUp = true;
            
            customer.Balance += 10;
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }
    }
}
