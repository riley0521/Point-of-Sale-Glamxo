using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSWinforms.Models
{
    public class DatabaseHelper
    {
        public static POSDBDataContext db = new POSDBDataContext();
        public static User user = new User();
        public static Item item = null;
        public static List<OrderDetail> cartList = new List<OrderDetail>();
    }
}
