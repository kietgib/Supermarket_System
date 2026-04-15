using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketSystem.BussinessLogicLayer.Entities
{
    // Entities/Order.cs
    public class Order
    {
            public string OrderID { get; set; }
            public string CustomerID { get; set; }
            public DateTime OrderDate { get; set; }
            public string EmployeeID { get; set; }

            public Order() { }
            public Order(string id, string custId, DateTime date, string empId)
            {
                OrderID = id;
                CustomerID = custId;
                OrderDate = date;
                EmployeeID = empId;
            }
    }
}
