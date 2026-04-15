using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketSystem.BussinessLogicLayer.Entities;
using System.Data;

namespace SupermarketSystem.BussinessLogicLayer.BLL
{
    public class ProductBLL : BaseBusinessLogic<Product>
    {
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
            string sql = $"UPDATE Products SET CategoryID = '{entity.CategoryID}', Name = N'{entity.Name}', " +
                         $"Price = {entity.Price}, Stock = {entity.Stock} WHERE ProductID = '{entity.ProductID}'";
            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        
        }
    }
}
