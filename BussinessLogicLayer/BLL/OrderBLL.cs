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
    //OrderBLL.cs là để xử lí liên kết giữa các bảng, ví dụ như khi xóa một khách hàng thì sẽ xóa luôn các đơn hàng liên quan đến khách hàng đó,
    //hoặc khi cập nhật thông tin sản phẩm thì sẽ cập nhật luôn thông tin sản phẩm trong các đơn hàng đã đặt.
    public class OrderBLL : BaseBusinessLogic<Order>
    {
        public override DataSet GetAll()
        {
            string sql = "SELECT * FROM Orders WHERE Status = 1";
            return dal.ExecuteQueryDataSet(sql, CommandType.Text, null);
        }

        public override bool Add(Order entity, ref string error)
        {
            // Lưu ý định dạng ngày tháng trong SQL thường là YYYY-MM-DD
            string formattedDate = entity.OrderDate.ToString("yyyy-MM-dd");
            string sql = $"INSERT INTO Orders (OrderID, CustomerID, OrderDate, EmployeeID) " +
                         $"VALUES ('{entity.OrderID}', '{entity.CustomerID}', '{formattedDate}', '{entity.EmployeeID}')";

            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        public override bool Update(Order entity, ref string error)
        {
            string formattedDate = entity.OrderDate.ToString("yyyy-MM-dd");
            string sql = $"UPDATE Orders SET CustomerID = '{entity.CustomerID}', " +
                         $"OrderDate = '{formattedDate}', EmployeeID = '{entity.EmployeeID}' " +
                         $"WHERE OrderID = '{entity.OrderID}'";

            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        public override bool Delete(object id, ref string error)
        {
            string sql = "UPDATE Orders SET Status = 0 WHERE OrderID = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };

            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error, parameters);
        }
        public DataSet OrderSearch(string orderID, string customerID, string orderDate)
        {
            return dal.SearchOrders(orderID, customerID, orderDate);
        }



    }
}
