using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketSystem.BussinessLogicLayer.Entities
{
    public class OrderDetail
    {
        internal decimal totalAmount;

        public string OrderID { get; set; }
        public string OrderDetailID { get; set; }
        public string ProductID { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount => UnitPrice * Quantity; // Tự động tính toán

        public OrderDetail() { }
    }
}
