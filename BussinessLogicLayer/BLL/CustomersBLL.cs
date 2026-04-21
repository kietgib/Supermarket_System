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
                db.Configuration.LazyLoadingEnabled = false;
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
        // ================= SEARCH =================
        public List<Customer> Search(string id, string name, string phone, string address)
        {
            using (var db = new SupermarketDBEntities1())
            {
                db.Configuration.LazyLoadingEnabled = false;

                var query = db.Customers.Where(c => c.Status == 1);

                if (!string.IsNullOrEmpty(id))
                    query = query.Where(c => c.CustomerID.Contains(id));

                if (!string.IsNullOrEmpty(name))
                    query = query.Where(c => c.Name.Contains(name));

                if (!string.IsNullOrEmpty(phone))
                    query = query.Where(c => c.Phone.Contains(phone));

                if (!string.IsNullOrEmpty(address))
                    query = query.Where(c => c.Address.Contains(address));

                return query.ToList();
            }
        }
    }
}