using SupermarketSystem.BussinessLogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static SupermarketSystem.DataLayer.DataAccessLayer;

namespace SupermarketSystem.BussinessLogicLayer.BLL
{
    // BLL/StaffBLL.cs
    public class StaffBLL : BaseBusinessLogic<Staff>
    {
        public override DataSet GetAll()
        {
            string sql = "SELECT * FROM Employees WHERE Status = 1";
            return dal.ExecuteQueryDataSet(sql, CommandType.Text, null);
        }

        public override bool Add(Staff entity, ref string error)
        {
            string sql = $"INSERT INTO Employees VALUES ('{entity.EmployeeID}', N'{entity.Name}', '{entity.Phone}', N'{entity.Position}',1 )";
            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        public override bool Update(Staff entity, ref string error)
        {
            string sql = $"UPDATE Employees SET Name = N'{entity.Name}', Phone = '{entity.Phone}', Position = N'{entity.Position}' WHERE EmployeeID = '{entity.EmployeeID}'";
            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }


        public override bool Delete(object id, ref string error)
        {
            if (id == null || string.IsNullOrWhiteSpace(id.ToString()))
            {
                error = "ID không hợp lệ";
                return false;
            }

            // Chuỗi SQL cập nhật Status cho cả 3 bảng liên quan
            // Giả sử bảng Orders và OrderDetails cũng có cột Status
            string sql = @"

        -- 3. Cuối cùng mới cập nhật trạng thái của chính nhân viên đó
            UPDATE Employees SET Status = 0 WHERE EmployeeID = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@id", id)
            };

            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error, parameters);
        }


        public DataSet StaffSearch(string employeeID, string name, string phone, string position)
        {
            // dal là đối tượng DataAccessLayer
            return dal.SearchStaff(employeeID, name, phone, position);
        }
    }
}
