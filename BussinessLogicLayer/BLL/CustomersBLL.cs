using SupermarketSystem.BussinessLogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketSystem.BussinessLogicLayer.BLL
{
    public class CustomersBLL : BaseBusinessLogic<Customers>
    {
        public override DataSet GetAll()
        {
            string sql = "SELECT * FROM Customers";
            return dal.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public override bool Add(Customers entity, ref string error)
        {
            // N' ' cho tiếng Việt có dấu ở cột Name và Address
            string sql = $"INSERT INTO Customers VALUES ('{entity.CustomerID}', N'{entity.Name}', '{entity.Phone}', N'{entity.Address}')";
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
            string sql = $"DELETE FROM Customers WHERE CustomerID = '{id}'";
            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }
    }
}
