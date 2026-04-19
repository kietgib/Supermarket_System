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
    public class CustomersBLL : BaseBusinessLogic<Customers>
    {
        public override DataSet GetAll()
        {
            string sql = "SELECT * FROM Customers WHERE Status = 1";
            return dal.ExecuteQueryDataSet(sql, CommandType.Text, null);
        }

        public override bool Add(Customers entity, ref string error)
        {
            // N' ' cho tiếng Việt có dấu ở cột Name và Address
            string sql = $"INSERT INTO Customers VALUES ('{entity.CustomerID}', N'{entity.Name}', '{entity.Phone}', N'{entity.Address}', 1)";
            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        public override bool Update(Customers entity, ref string error)
        {
            string sql = $"UPDATE Customers SET Name = N'{entity.Name}', Phone = '{entity.Phone}', Address = N'{entity.Address}' " +
                         $"WHERE CustomerID = '{entity.CustomerID}'";
            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        public override bool Delete(object id, ref string error)
        {
            string sql = "UPDATE Customers SET Status = 0 WHERE CustomerID = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };

            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error, parameters);
        }

        public DataSet SearchCustomers(string id, string name, string phone, string address)
        {
            return dal.SearchCustomers(id, name, phone, address);
        }
    }
}
