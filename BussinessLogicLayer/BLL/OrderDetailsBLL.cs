using System;
using System.Collections.Generic;
using System.Linq;
using SupermarketSystem;

namespace SupermarketSystem.BussinessLogicLayer.BLL
{
    public class OrderDetailsBLL
    {
        // ================= GET ALL =================
        public List<OrderDetail> GetAll()
        {
            using (var db = new SupermarketDBEntities1())
            {
                db.Configuration.LazyLoadingEnabled = false;
                return db.OrderDetails.ToList();
            }
        }

        // ================= ADD =================
        public bool Add(OrderDetail entity, ref string error)
        {
            try
            {
                using (var db = new SupermarketDBEntities1())
                {
                    // 🔥 1. Check product tồn tại
                    var product = db.Products.Find(entity.ProductID);

                    if (product == null)
                    {
                        error = "Sản phẩm không tồn tại";
                        return false;
                    }

                    // 🔥 2. Check tồn kho
                    if (product.Stock < entity.Quantity)
                    {
                        error = "Không đủ hàng trong kho";
                        return false;
                    }

                    // 🔥 3. Tính TotalAmount (tránh user nhập sai)
                    entity.TotalAmount = entity.UnitPrice * entity.Quantity;

                    // 🔥 4. Thêm OrderDetail
                    db.OrderDetails.Add(entity);

                    // 🔥 5. Trừ kho
                    product.Stock -= entity.Quantity;

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
        public bool Update(OrderDetail entity, ref string error)
        {
            try
            {
                using (var db = new SupermarketDBEntities1())
                {
                    var od = db.OrderDetails.Find(entity.OrderDetailID);

                    if (od == null)
                    {
                        error = "Không tìm thấy chi tiết hóa đơn";
                        return false;
                    }

                    od.ProductID = entity.ProductID;
                    od.Quantity = entity.Quantity;
                    od.UnitPrice = entity.UnitPrice;
                    od.TotalAmount = entity.UnitPrice * entity.Quantity;

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
                    var od = db.OrderDetails.Find(id);

                    if (od == null)
                    {
                        error = "Không tìm thấy chi tiết hóa đơn";
                        return false;
                    }

                    // 🔥 Hoàn lại kho khi xóa
                    var product = db.Products.Find(od.ProductID);
                    if (product != null)
                    {
                        product.Stock += od.Quantity;
                    }

                    db.OrderDetails.Remove(od);
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
        public List<OrderDetail> Search(string orderID, string orderDetailID, string productID,
                                        string unitPrice, string quantity, string totalAmount)
        {
            using (var db = new SupermarketDBEntities1())
            {
                db.Configuration.LazyLoadingEnabled = false;

                var query = db.OrderDetails.AsQueryable();

                if (!string.IsNullOrEmpty(orderDetailID))
                    query = query.Where(od => od.OrderDetailID.Contains(orderDetailID));

                if (!string.IsNullOrEmpty(orderID))
                    query = query.Where(od => od.OrderID.Contains(orderID));

                if (!string.IsNullOrEmpty(productID))
                    query = query.Where(od => od.ProductID.Contains(productID));

                if (!string.IsNullOrEmpty(unitPrice) && decimal.TryParse(unitPrice, out decimal parsedPrice))
                    query = query.Where(od => od.UnitPrice == parsedPrice);

                if (!string.IsNullOrEmpty(quantity) && int.TryParse(quantity, out int parsedQty))
                    query = query.Where(od => od.Quantity == parsedQty);

                if (!string.IsNullOrEmpty(totalAmount) && decimal.TryParse(totalAmount, out decimal parsedTotal))
                    query = query.Where(od => od.TotalAmount == parsedTotal);

                return query.ToList();
            }
        }
    }
}