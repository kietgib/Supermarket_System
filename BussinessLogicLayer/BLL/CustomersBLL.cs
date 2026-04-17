using SupermarketSystem;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SupermarketSystem.BussinessLogicLayer.BLL
{
    public class CustomersBLL
    {
        public List<Customer> GetAll()
        {
            using (var db = new SupermarketDBEntities1())
            {
                return db.Customers.ToList();
            }
        }

        public bool Add(Customer entity, ref string error)
        {
            try
            {
                using (var db = new SupermarketDBEntities1())
                {
                    entity.Status = 1;
                    db.Customers.Add(entity);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public bool Update(Customer entity, ref string error)
        {
            try
            {
                using (var db = new SupermarketDBEntities1())
                {
                    var c = db.Customers.Find(entity.CustomerID);
                    if (c == null)
                    {
                        error = "Không tìm thấy khách hàng";
                        return false;
                    }

                    c.Name = entity.Name;
                    c.Phone = entity.Phone;
                    c.Address = entity.Address;

                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public bool Delete(string id, ref string error)
        {
            try
            {
                using (var db = new SupermarketDBEntities1())
                {
                    var c = db.Customers.Find(id);
                    if (c == null)
                    {
                        error = "Không tìm thấy khách hàng";
                        return false;
                    }

                    db.Customers.Remove(c);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}