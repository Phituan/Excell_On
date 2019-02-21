using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Account
    {
        public Guid AccountId { get; set; }
        public Guid EmployeeId { get; set; }
        public string RoleName { get; set; }
        public string AccountUserName { get; set; }
        public string AccountPassword { get; set; }
        public bool AccountIsLocked { get; set; }
        public bool AccountIsDelete { get; set; }

        public  Employee Employee { get; set; }
    }
}
