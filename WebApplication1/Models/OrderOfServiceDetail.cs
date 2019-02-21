using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class OrderOfServiceDetail
    {
        public Guid OrderOfServiceId { get; set; }
        public Guid ServiceId { get; set; }
        public int OrderOfServiceDetailPrice { get; set; }
        public DateTime OrderOfServiceDetailFromDate { get; set; }
        public DateTime OrderOfServiceDetailToDate { get; set; }
        public int OrderOfServiceDetailNumberOfEmployee { get; set; }
        public bool OrderOfServiceDetailIsDelete { get; set; }

        public  OrderOfService OrderOfService { get; set; }
        public  Service Service { get; set; }
    }
}
