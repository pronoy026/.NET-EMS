using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using V2_Ems_MVC_RepoPattern_InMemory.Models;

namespace V2_Ems_MVC_RepoPattern_InMemory.Data
{
    public class EmployeeRepository : IRepository
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
        public bool Add(Employee employee) {
            try
            {
                employees.Add(employee);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Employee employee)
        {
            try
            {
                employees.Remove(employee);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(Employee employee)
        {
            try
            {
                var emp = employees.Find(e => e.Id == employee.Id);
                emp.FirstName = employee.FirstName;
                emp.LastName = employee.LastName;
                emp.Email = employee.Email;
                emp.Phone = employee.Phone;
                emp.DateOfBirth = employee.DateOfBirth;
                emp.DateOfJoining = employee.DateOfJoining;
                emp.JobTitle = employee.JobTitle;
                emp.Gender = employee.Gender;
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<Employee> GetByGender(Gender gender)
        {
            var emps = employees.FindAll(e => e.Gender == gender);
            return emps;
        }

        public Employee GetById(int employeeId)
        {
            var emp = employees.Find(e => e.Id == employeeId);
            return emp;
        }

        public IEnumerable<Employee> GetByJobTitle(JobTitle jobTitle)
        {
            var emps = employees.FindAll(e => e.JobTitle == jobTitle);
            return emps;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
