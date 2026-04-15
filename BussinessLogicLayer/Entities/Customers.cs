using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketSystem.BussinessLogicLayer.Entities
{
    public class Customers
    {
        public string CustomerID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Customers() { }
        public Customers(string id, string name, string phone, string address)
        {
            CustomerID = id;
            Name = name;
            Phone = phone;
            Address = address;
        }
    }
}
