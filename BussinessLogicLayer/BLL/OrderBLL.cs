using System;
using System.Collections.Generic;
using System.Linq;
using SupermarketSystem;

namespace SupermarketSystem.BussinessLogicLayer.BLL
{
    public class OrderBLL
    {
        // ================= GET ALL =================
        public List<Order> GetAll()
        {
            using (var db = new SupermarketDBEntities1())
            {
                db.Configuration.LazyLoadingEnabled = false;
                return db.Orders.ToList();
            }
        }

        // ================= ADD =================
        public bool Add(Order entity, ref string error)
        {
            try
            {
                using (var db = new SupermarketDBEntities1())
                {
                    db.Orders.Add(entity);
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

        // ================= UPDATE =================
        public bool Update(Order entity, ref string error)
        {
            try
            {
                using (var db = new SupermarketDBEntities1())
                {
                    var o = db.Orders.Find(entity.OrderID);

                    if (o == null)
                    {
                        error = "Không tìm thấy hóa đơn";
                        return false;
                    }

                    o.CustomerID = entity.CustomerID;
                    o.OrderDate = entity.OrderDate;

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

        // ================= DELETE =================
        public bool Delete(string id, ref string error)
        {
            try
            {
                using (var db = new SupermarketDBEntities1())
                {
                    var o = db.Orders.Find(id);

                    if (o == null)
                    {
                        error = "Không tìm thấy hóa đơn";
                        return false;
                    }

                    // Xóa chi tiết trước (FK)
                    var details = db.OrderDetails
                                    .Where(d => d.OrderID == id)
                                    .ToList();

                    foreach (var d in details)
                        db.OrderDetails.Remove(d);

                    db.Orders.Remove(o);
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
        public List<Order> Search(string orderID, string customerID, string orderDate)
        {
            using (var db = new SupermarketDBEntities1())
            {
                db.Configuration.LazyLoadingEnabled = false;

                var query = db.Orders.AsQueryable();

                if (!string.IsNullOrEmpty(orderID))
                    query = query.Where(o => o.OrderID.Contains(orderID));

                if (!string.IsNullOrEmpty(customerID))
                    query = query.Where(o => o.CustomerID.Contains(customerID));

                if (!string.IsNullOrEmpty(orderDate) && DateTime.TryParse(orderDate, out DateTime parsedDate))
                    query = query.Where(o => o.OrderDate == parsedDate);

                return query.ToList();
            }
        }
    }
}