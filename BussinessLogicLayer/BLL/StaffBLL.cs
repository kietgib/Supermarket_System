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
            // Khớp với hàm ExecuteQueryDataSet trong DAL của bạn
            string sql = "SELECT * FROM Employees";
            return dal.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public override bool Add(Staff entity, ref string error)
        {
            string sql = $"INSERT INTO Employees VALUES ('{entity.EmployeeID}', N'{entity.Name}', '{entity.Phone}', N'{entity.Position}')";
            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        public override bool Update(Staff entity, ref string error)
        {
            string sql = $"UPDATE Employees SET Name = N'{entity.Name}', Phone = '{entity.Phone}', Position = N'{entity.Position}' WHERE EmployeeID = '{entity.EmployeeID}'";
            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        public override bool Delete(object id, ref string error)
        {
            string sql = $"DELETE FROM Employees WHERE EmployeeID = '{id}'";
            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }
        // Logic riêng của Employee
        //private bool IsEmployeeIDExists(string id)
        //{
        //    string query = "SELECT COUNT(*) FROM Employees WHERE EmployeeID=@id";
        //    return Convert.ToInt32(dal.ExecuteScalar(query,
        //        new SqlParameter("@id", id))) > 0;
        //}

        //private void UpdateRelatedOrders(string empId)
        //{
        //    // Cập nhật các đơn hàng liên quan
        //}

        //public DataTable GetByPosition(string position)
        //{
        //    string query = "SELECT * FROM Employees WHERE Position=@pos";
        //    return dal.ExecuteQuery(query, new SqlParameter("@pos", position));
        //}
    }
}
