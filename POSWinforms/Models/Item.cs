using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSWinforms.Models
{
    public class Item
    {
        public long ID { get; set; }
        public long ItemNumber { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string Size { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stocks { get; set; }
        public int ReStockLevel { get; set; }

    }
}
