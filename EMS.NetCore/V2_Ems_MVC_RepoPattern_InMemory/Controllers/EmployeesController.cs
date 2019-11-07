using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using V2_Ems_MVC_RepoPattern_InMemory.Data;
using V2_Ems_MVC_RepoPattern_InMemory.Models;

namespace V2_Ems_MVC_RepoPattern_InMemory.Controllers
{
    public class EmployeesController : Controller
    {
        IRepository _repository = null;
        public EmployeesController(IRepository repository)
        {
            _repository = repository;
        }
        // GET: Employees
        public ActionResult Index()
        {
            return View(_repository.GetEmployees());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                // TODO: Add insert logic 
                if(ModelState.IsValid)
                {
                    _repository.Add(employee);
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = _repository.GetById(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                return View(employee);
            }
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee employee)
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View();
                }
                if (id != employee.Id)
                {
                    return BadRequest();
                }
                bool result = _repository.Edit(employee);
                if (result)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return Content("<script>alert('Edit Failed : Server Error!');</script>");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employees/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int? id)
        {
            try
            {
                // TODO: Add delete logic here
                var emp = _repository.GetById(id.GetValueOrDefault());
                if (emp == null)
                {
                    return NotFound();
                }
                bool result = _repository.Delete(emp);
                if (result)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return Content("<script>alert('Delete Failed : Server Error!');</script>");
                }
            }
            catch
            {
                return View();
            }
        }

        public IActionResult SearchByJobtitle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchByJobTitle(JobTitle jobTitle)
        {
            var emp = _repository.GetByJobTitle(jobTitle);
            if (emp.Count() == 0)
            {
                ViewBag.Message = "No result found!";
                return View();
            }
            return View(emp);
        }

        public IActionResult SearchByGender()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchByGender(Gender gender)
        {
            var employeesG = _repository.GetByGender(gender);
            if (employeesG.Count() == 0)
            {
                ViewBag.Message = "No result found!";
                return View();
            }
            return View(employeesG);
        }


    }
}