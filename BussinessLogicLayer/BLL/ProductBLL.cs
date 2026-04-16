using SupermarketSystem.BussinessLogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketSystem.BussinessLogicLayer.BLL
{
    public class ProductBLL : BaseBusinessLogic<Product>
    {
        public SqlDbType Quantity { get; private set; }
        public SqlDbType ProductID { get; private set; }

        public override bool Add(Product entity, ref string error)
        {
            // Lưu ý: N' ' dùng cho các trường tiếng Việt có dấu như Name
            string sql = $"INSERT INTO Products VALUES ('{entity.ProductID}', '{entity.CategoryID}', N'{entity.Name}', {entity.Price}, {entity.Stock})";
            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }
        public override bool Delete(object id, ref string error)
        {
            string sql = $"DELETE FROM Products WHERE ProductID = '{id}'";
            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }
        public override DataSet GetAll()
        {
            string sql = "SELECT * FROM Products";
            return dal.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public override bool Update(Product entity, ref string error)
        {
            // Lệnh SQL trừ kho, đảm bảo không trừ quá số lượng tồn (Stock >= @qty)
            string sql = "UPDATE Products SET Stock = Stock - @qty WHERE ProductID = @id AND Stock >= @qty";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", ProductID ),
                new SqlParameter("@qty", Quantity)
            };

            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error, parameters);
        }
    }
}
