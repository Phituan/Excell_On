using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Service
    {
        public Service()
        {
           
        }

        public Guid ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceImage { get; set; }
        public int ServicePrice { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceCharge { get; set; }
        public bool ServiceIsDelete { get; set; }
        public Guid EmployeeEmployeeId { get; set; }
        public Guid ServiceTypeServiceTypeId { get; set; }
        public Guid CompanyCompanyId { get; set; }

        public  Company CompanyCompany { get; set; }
        public  Employee EmployeeEmployee { get; set; }
        public  ServiceType ServiceTypeServiceType { get; set; }
        public  List<OrderOfServiceDetail> OrderOfServiceDetail { get; set; }
    }
}
