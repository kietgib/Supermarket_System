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
                    entity.Status = 1; // active
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

                    // 🔥 Soft delete (không xóa thật)
                    p.Status = 0;

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