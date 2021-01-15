using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSWinforms.Models
{
    public class Order
    {
        public long ID { get; set; }
        public long CustomerID { get; set; }
        public string OrderStatus { get; set; }
        public string OrderDate { get; set; }
        public double Total { get; set; }
    }
}
