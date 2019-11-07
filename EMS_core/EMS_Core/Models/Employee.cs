using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_Core.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public int DepartmentNo { get; set; }
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfJoining { get; set; }
        public int? ReportingTo { get; set; }
        [Range(1000000000, 9999999999, ErrorMessage ="Phone No must be of 10 digits")]
        public long Phone { get; set; }
        public int Salary { get; set; }
        public int Commission { get; set; }
        public string JobTitle { get; set; }
    }
}
