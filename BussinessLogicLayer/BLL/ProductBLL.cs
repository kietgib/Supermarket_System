using System;
using System.Collections.Generic;
using System.Linq;
using SupermarketSystem;



namespace SupermarketSystem.BussinessLogicLayer.BLL
{
    public class ProductBLL
    {
        // ================= GET ALL =================
        public List<Product> GetAll()
        {
            using (var db = new SupermarketDBEntities1())
            {
                db.Configuration.LazyLoadingEnabled = false;
                return db.Products.ToList();
            }
        }

        // ================= ADD =================
        public bool Add(Product entity, ref string error)
        {
            try
            {
                using (var db = new SupermarketDBEntities1())
                {
                    entity.Status = 1;
                    db.Products.Add(entity);
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
        public bool Update(Product entity, ref string error)
        {
            try
            {
                using (var db = new SupermarketDBEntities1())
                {
                    var p = db.Products.Find(entity.ProductID);

                    if (p == null)
                    {
                        error = "Không tìm thấy sản phẩm";
                        return false;
                    }

                    p.CategoryID = entity.CategoryID;
                    p.Name = entity.Name;
                    p.Price = entity.Price;
                    p.Stock = entity.Stock;
                    p.Status = entity.Status;

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

        // ================= DELETE (Soft Delete) =================
        public bool Delete(string id, ref string error)
        {
            try
            {
                using (var db = new SupermarketDBEntities1())
                {
                    var p = db.Products.Find(id);

                    if (p == null)
                    {
                        error = "Không tìm thấy sản phẩm";
                        return false;
                    }

                    p.Status = 0; // Soft delete
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

        private readonly SupermarketDBEntities1 _db = new SupermarketDBEntities1();
        public List<Employee> EmployeeSearch(string employeeID, string name, string phone, string position, ref string error)
        {
            try
            {
                var query = _db.Employees.AsQueryable().Where(e => e.Status == 1);

                if (!string.IsNullOrEmpty(employeeID))
                {
                    query = query.Where(e => e.EmployeeID.Contains(employeeID));
                }

                if (!string.IsNullOrEmpty(name))
                {
                    query = query.Where(e => e.Name.Contains(name));
                }

                if (!string.IsNullOrEmpty(phone))
                {
                    query = query.Where(e => e.Phone.Contains(phone));
                }

                if (!string.IsNullOrEmpty(position))
                {
                    query = query.Where(e => e.Position.Contains(position));
                }

                return query.ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
        // ================= SEARCH =================
        public List<Product> Search(string categoryID, string productID, string name, string price, string stock)
        {
            using (var db = new SupermarketDBEntities1())
            {
                db.Configuration.LazyLoadingEnabled = false;

                var query = db.Products.Where(p => p.Status == 1);

                if (!string.IsNullOrEmpty(productID))
                    query = query.Where(p => p.ProductID.Contains(productID));

                if (!string.IsNullOrEmpty(categoryID))
                    query = query.Where(p => p.CategoryID.Contains(categoryID));

                if (!string.IsNullOrEmpty(name))
                    query = query.Where(p => p.Name.Contains(name));

                if (!string.IsNullOrEmpty(price) && decimal.TryParse(price, out decimal parsedPrice))
                    query = query.Where(p => p.Price == parsedPrice);

                if (!string.IsNullOrEmpty(stock) && int.TryParse(stock, out int parsedStock))
                    query = query.Where(p => p.Stock == parsedStock);

                return query.ToList();
            }
        }
    }
}