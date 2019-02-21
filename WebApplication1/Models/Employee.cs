using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
        public Employee()
        {
            
        }

        public Guid EmployeeId { get; set; }
        public Guid DepartmentId { get; set; }
        public string EmployeeFirtName { get; set; }
        public string EmployeeLastName { get; set; }
        public bool? EmployeeGender { get; set; }
        public DateTime? EmployeeDateOfBirth { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeAvatar { get; set; }
        public bool EmployeeIsDelete { get; set; }

        public  Account Account { get; set; }
        public  List<Service> Service { get; set; }
    }
}
