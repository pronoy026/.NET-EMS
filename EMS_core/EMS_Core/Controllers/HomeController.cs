using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EMS_Core.Models;

namespace EMS_Core.Controllers
{
    public class HomeController : Controller
    {
        static List<Employee> employeeList = new List<Employee>()
            {
                new Employee{ Id=1, Name = "John", Email="doe@hotmail.com", DepartmentNo=20, Gender= "Male",
                DateOfBirth = new DateTime(1990,3,23), DateOfJoining = new DateTime(2005,12,7),
                ReportingTo = 10, Phone = 9874561230, Salary=2000, Commission = 500, JobTitle = "Receptionist"
                },
                new Employee{ Id=2, Name = "Alok", Email="fhoe@hotmail.com", DepartmentNo=30, Gender="Male",
                DateOfBirth = new DateTime(1990,3,20), DateOfJoining = new DateTime(2005,12,12),
                ReportingTo = 20, Phone = 9874561230, Salary=2000, Commission = 500, JobTitle = "Developer",
                },
                new Employee{ Id=3, Name = "Goutam", Email="ghosthunter@hotmail.com", DepartmentNo=20, Gender="Male",
                DateOfBirth = new DateTime(1990,3,20), DateOfJoining = new DateTime(2005,12,12),
                ReportingTo = 30, Phone = 9874561230, Salary=2000, Commission = 500, JobTitle = "CEO"
                }
            };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult List()
        {
            //employee list
            return View(employeeList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            employeeList.Add(employee);
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Edit(int Id, Employee employee)
        {
            var emp = employeeList.Find(e => e.Id == Id);
            if (employee == null)
            {
                return BadRequest();
            }
            if(Id!= employee.Id)
            {
                return BadRequest();
            }
            emp.Name = employee.Name;
            emp.Email = employee.Email;
            emp.Gender = employee.Gender;
            emp.JobTitle = employee.JobTitle;
            emp.DateOfBirth = employee.DateOfBirth;
            emp.DateOfJoining = employee.DateOfJoining;
            emp.DepartmentNo = employee.DepartmentNo;
            emp.ReportingTo = employee.ReportingTo;
            emp.Commission = employee.Commission;
            emp.Salary = employee.Salary;
            emp.Phone = employee.Phone;

            return RedirectToAction("List");
        }

        public IActionResult Edit(int Id)
        {
            var employee = employeeList.Find(e => e.Id == Id);
            if (employee == null)
            {
                return BadRequest();
            }
            return View(employee);
        }

        public IActionResult Delete(int Id)
        {
            var employee = employeeList.Find(e => e.Id == Id);
            if (employee == null)
            {
                return BadRequest();
            }
            employeeList.Remove(employee);
            return RedirectToAction("List");
        }
    }
}
