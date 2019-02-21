using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class OrderOfService
    {
        public OrderOfService()
        {
            
        }

        public Guid OrderOfServiceId { get; set; }
        public string OrderOfServiceDescription { get; set; }
        public int OrderOfServicePrice { get; set; }
        public DateTime OrderOfServiceCreatedAt { get; set; }
        public string OrderOfServicePaymentMethod { get; set; }
        public DateTime OrderOfServicePaymentDate { get; set; }
        public DateTime OrderOfServiceBillDate { get; set; }
        public int OrderOfServiceStatus { get; set; }
        public bool OrderOfServiceIsDelete { get; set; }

        public  List<OrderOfServiceDetail> OrderOfServiceDetail { get; set; }
    }
}
