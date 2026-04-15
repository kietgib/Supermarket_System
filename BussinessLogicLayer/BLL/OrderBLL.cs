using SupermarketSystem.BussinessLogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
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
            // Lấy danh sách hóa đơn, có thể dùng JOIN để hiển thị tên khách/nhân viên cho đẹp
            string sql = "SELECT * FROM Orders";
            return dal.ExecuteQueryDataSet(sql, CommandType.Text);
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
            // Cẩn thận: Nếu xóa hóa đơn cha, bạn có thể cần xóa các hóa đơn chi tiết trước (Cascade Delete)
            string sql = $"DELETE FROM Orders WHERE OrderID = '{id}'";
            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }
    }
}
