using System;
using System.Collections.Generic;
using System.Linq;
using SupermarketSystem;

namespace SupermarketSystem.BussinessLogicLayer.BLL
{
    public class StaffBLL
    {
        // EF context
        SupermarketDBEntities1 db = new SupermarketDBEntities1();

        // ================= GET ALL =================
        public List<Employee> GetAll()
        {
            return db.Employees
                     .Where(e => e.Status == 1) // chỉ lấy đang hoạt động
                     .ToList();
        }

        // ================= ADD =================
        public bool Add(Employee entity, ref string error)
        {
            try
            {
                entity.Status = 1;
                db.Employees.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // ================= UPDATE =================
        public bool Update(Employee entity, ref string error)
        {
            try
            {
                var s = db.Employees.Find(entity.EmployeeID);
                if (s != null)
                {
                    s.Name = entity.Name;
                    s.Phone = entity.Phone;
                    s.Position = entity.Position;

                    db.SaveChanges();
                }
                return true;
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
                var s = db.Employees.Find(id);
                if (s != null)
                {
                    // 👉 soft delete (giống code cũ)
                    s.Status = 0;

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}