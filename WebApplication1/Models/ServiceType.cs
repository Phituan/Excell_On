using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ServiceType
    {
        

        public Guid ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }

        public List<Service> Service { get; set; }
    }
}
