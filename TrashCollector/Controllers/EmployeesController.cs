using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Exchange.WebServices.Data;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeesController(ApplicationDbContext db)
        {
           _db = db;

        }

       
        // GET: EmployeesController
        public ActionResult Index()
        {
            var employeeId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _db.Customers.Where(c => c.IdentityUserId == employeeId).FirstOrDefault();

            if (employee == null)
            {
                return RedirectToAction("Create");
            }
            else
            {
                return View(employee);
            }

        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int? id)
        {
            var employeesInDatabase = _db.Customers.Where(c => c.Id == id).SingleOrDefault();

            if (id == null)
            {
                return NotFound();
            }
            return View(employeesInDatabase);
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            Employee employee = new Employee()
;            return View(employee);
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Add(employee);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);

        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int? id)
        {
            if( id == null)
            {
                return NotFound();
            }

            var employee = _db.Employees.SingleOrDefault(c => c.Id == id);

            if(employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if(ModelState.IsValid)
            {
                _db.Employees.Update(employee);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int? id)
        {
            var employeeToDelete = _db.Employees.Where(c => c.Id == id).SingleOrDefault();

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
            _db.Employees.Remove(employee);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
