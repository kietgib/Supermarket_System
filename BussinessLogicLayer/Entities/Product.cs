using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketSystem.BussinessLogicLayer.Entities
{
    public class Product
    {
        public string ProductID { get; set; }
        public string CategoryID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Stock { get; set; }

        public string Status { get; set; } // Thêm trường Status để quản lý tình trạng sản phẩm

        // Constructor
        public Product() { }

        public Product(string id, string id2, string name, string price, string stock, string status)
        {
            ProductID = id;
            CategoryID = id2;
            Name = name;
            Price = price;
            Stock = stock;
            Status = status;
        }

        // Validation tại chính entity
        public bool IsValid()
        {
            return !string.IsNullOrEmpty(ProductID)
                && !string.IsNullOrEmpty(Name);
        }
    }
}
