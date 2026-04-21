using System;
using System.Collections.Generic;
using System.Linq;
using SupermarketSystem;

namespace SupermarketSystem.BussinessLogicLayer.BLL
{
    public class StaffBLL
    {
        // ================= GET ALL =================
        public List<Employee> GetAll()
        {
            using (var db = new SupermarketDBEntities1())
            {
                db.Configuration.LazyLoadingEnabled = false;
                return db.Employees
                         .Where(e => e.Status == 1)
                         .ToList();
            }
        }

        // ================= ADD =================
        public bool Add(Employee entity, ref string error)
        {
            try
            {
                using (var db = new SupermarketDBEntities1())
                {
                    entity.Status = 1;
                    db.Employees.Add(entity);
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
        public bool Update(Employee entity, ref string error)
        {
            try
            {
                using (var db = new SupermarketDBEntities1())
                {
                    var s = db.Employees.Find(entity.EmployeeID);
                    if (s == null)
                    {
                        error = "Không tìm thấy nhân viên";
                        return false;
                    }

                    s.Name = entity.Name;
                    s.Phone = entity.Phone;
                    s.Position = entity.Position;

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
                    var s = db.Employees.Find(id);
                    if (s == null)
                    {
                        error = "Không tìm thấy nhân viên";
                        return false;
                    }

                    s.Status = 0; // Soft delete
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
        public List<Employee> Search(string employeeID, string name, string phone, string position)
        {
            using (var db = new SupermarketDBEntities1())
            {
                db.Configuration.LazyLoadingEnabled = false;

                var query = db.Employees.Where(e => e.Status == 1);

                if (!string.IsNullOrEmpty(employeeID))
                    query = query.Where(e => e.EmployeeID.Contains(employeeID));

                if (!string.IsNullOrEmpty(name))
                    query = query.Where(e => e.Name.Contains(name));

                if (!string.IsNullOrEmpty(phone))
                    query = query.Where(e => e.Phone.Contains(phone));

                if (!string.IsNullOrEmpty(position))
                    query = query.Where(e => e.Position.Contains(position));

                return query.ToList();
            }
        }
    }
}