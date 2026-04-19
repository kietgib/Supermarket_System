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

        private readonly SupermarketDBContext _db = new SupermarketDBContext();
        public List<Staff> StaffSearch(string employeeID, string name, string phone, string position, ref string error)
        {
            try
            {
                // 1. Lấy toàn bộ nhân viên có Status = 1 (IQueryable giúp tối ưu hóa câu lệnh trước khi chạy)
                var query = _db.Staffs.AsQueryable().Where(s => s.Status == 1);

                // 2. Kiểm tra từng điều kiện (Tương đương LIKE trong SQL)
                if (!string.IsNullOrEmpty(employeeID))
                {
                    query = query.Where(s => s.EmployeeId.Contains(employeeID));
                }

                if (!string.IsNullOrEmpty(name))
                {
                    query = query.Where(s => s.Name.Contains(name));
                }

                if (!string.IsNullOrEmpty(phone))
                {
                    query = query.Where(s => s.Phone.Contains(phone));
                }

                if (!string.IsNullOrEmpty(position))
                {
                    query = query.Where(s => s.Position.Contains(position));
                }

                // 3. Thực thi truy vấn và trả về danh sách Object
                return query.ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
}