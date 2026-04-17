using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketSystem.BussinessLogicLayer.Entities
{
    // Entities/Employee.cs
    public class Staff
    {
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }

        public int Status { get; set; } // 1 = Active, 0 = Inactive (Soft Delete)

        // Constructor
        public Staff() { }

        public Staff(string id, string name, string phone, string position, int status)
        {
            EmployeeID = id;
            Name = name;
            Phone = phone;
            Position = position;
            Status = status;
        }

        // Validation tại chính entity
        public bool IsValid()
        {
            return !string.IsNullOrEmpty(EmployeeID)
                && !string.IsNullOrEmpty(Name);
        }
    }
}
