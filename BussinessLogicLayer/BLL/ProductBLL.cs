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
            string sql = $"INSERT INTO Products VALUES ('{entity.ProductID}', '{entity.CategoryID}', N'{entity.Name}', {entity.Price}, {entity.Stock}, {entity.Status})";
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
            UPDATE Products SET Status = 0 WHERE ProductID = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                 new SqlParameter("@id", id)
            };

            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error, parameters);
        }
        public override DataSet GetAll()
        {
            string sql = "SELECT * FROM Products";
            return dal.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public override bool Update(Product entity, ref string error)
        {
            string sql = $"UPDATE Products SET CategoryID = '{entity.CategoryID}', Name = N'{entity.Name}', Price = N'{entity.Price}', Stock = N'{entity.Stock}', Status = {entity.Status} WHERE ProductID = '{entity.ProductID}'";
            // Lệnh SQL trừ kho, đảm bảo không trừ quá số lượng tồn (Stock >= @qty)
            //string sql = "UPDATE Products SET Stock = Stock - @qty WHERE ProductID = @id AND Stock >= @qty";

            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //    new SqlParameter("@id", ProductID ),
            //    new SqlParameter("@qty", Quantity)
            //};

            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }
    }
}
