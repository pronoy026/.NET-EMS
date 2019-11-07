using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using V1_Ems_.NetCore_MVC_InMemory.Models;

namespace V1_Ems_.NetCore_MVC_InMemory.Controllers
{
    public class EmployeesController : Controller
    {

        static List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1, FirstName="John", LastName="Doe", DateOfBirth= new DateTime(1990,1,1),
                DateOfJoining = new DateTime(2016,1,1), Phone = 1234567890, Email = "johndoe@gmail.com",
                Gender = Gender.Male, JobTitle = JobTitle.Manager },
                new Employee{Id=2, FirstName="Conner", LastName="Murphy", DateOfBirth= new DateTime(1995,1,1),
                DateOfJoining = new DateTime(2016,1,1), Phone = 4568521597, Email = "cmurphy@gmail.com",
                Gender = Gender.Male, JobTitle = JobTitle.Analyst },
                new Employee{Id=3, FirstName="Bred", LastName="Dawson", DateOfBirth= new DateTime(1970,1,1),
                DateOfJoining = new DateTime(2016,1,1), Phone = 6543574516, Email = "bredthedaw@gmail.com",
                Gender = Gender.Male, JobTitle = JobTitle.President },
                new Employee{Id=4, FirstName="Johanna", LastName="Rickky", DateOfBirth= new DateTime(1996,1,1),
                DateOfJoining = new DateTime(2016,1,1), Phone = 5554446669, Email = "johndoe@gmail.com",
                Gender = Gender.Female, JobTitle = JobTitle.Developer },

            };
        public IActionResult Index()
        {
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employees.Add(employee);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            var employee = employees.Find(e => e.Id == id);
            if( employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(int id, Employee employee)
        {
            if(!ModelState.IsValid)
            {
                return View(employee);
            }

            if(id!= employee.Id)
            {
                return BadRequest();
            }
            var emp = employees.Find(e => e.Id == employee.Id);
            if (employee == null)
            {
                return NotFound();
            }
            emp.FirstName = employee.FirstName;
            emp.LastName = employee.LastName;
            emp.Email = employee.Email;
            emp.Phone = employee.Phone;
            emp.DateOfBirth = employee.DateOfBirth;
            emp.DateOfJoining = employee.DateOfJoining;
            emp.JobTitle = employee.JobTitle;
            emp.Gender = employee.Gender;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var employee = employees.Find(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        public IActionResult Delete(int? id)
        {
            var employee = employees.Find(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var employee = employees.Find(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            } 
            else
            {
                employees.Remove(employee);
                return RedirectToAction(nameof(Index));
            }
            
        }

        public IActionResult GetById()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetById(int id)
        {
            var employee = employees.Find(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        public IActionResult SearchByGender()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchByGender(Gender gender)
        {
            var employeesG = employees.FindAll(e => e.Gender == gender);
            if (employeesG.Count == 0)
            {
                ViewBag.Message = "No result found!";
                return View();
            }
            return View(employeesG);
        }

        public IActionResult SearchByJobTitle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchByJobTitle(JobTitle jobTitle)
        {
            var emp = employees.FindAll(e => e.JobTitle == jobTitle);
            if (emp.Count == 0)
            {
                ViewBag.Message = "No result found!";
                return View();
            }
            return View(emp);
        }

    }
}