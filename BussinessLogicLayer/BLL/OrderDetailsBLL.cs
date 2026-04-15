using SupermarketSystem.BussinessLogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketSystem.BussinessLogicLayer.BLL
{
    public class OrderDetailsBLL : BaseBusinessLogic<OrderDetail>
    {
        public override DataSet GetAll()
        {
            return dal.ExecuteQueryDataSet("SELECT * FROM OrderDetails", CommandType.Text);
        }

        // Hàm này sẽ thực hiện "liên kết" sửa bảng Products khi thêm Detail
        public override bool Add(OrderDetail entity, ref string error)
        {
            // 1. Câu lệnh thêm vào bảng Chi tiết hóa đơn
            string sqlDetail = $"INSERT INTO OrderDetails VALUES ('{entity.OrderDetailID}', '{entity.OrderID}', " +
                               $"'{entity.ProductID}', {entity.UnitPrice}, {entity.Quantity}, {entity.TotalAmount})";

            bool isAdded = dal.MyExecuteNonQuery(sqlDetail, CommandType.Text, ref error);

            // 2. NẾU THÊM THÀNH CÔNG -> Tự động trừ kho ở bảng Products
            if (isAdded)
            {
                string sqlUpdateStock = $"UPDATE Products SET Stock = Stock - {entity.Quantity} " +
                                        $"WHERE ProductID = '{entity.ProductID}'";
                // Chạy lệnh update bảng khác ngay lập tức
                return dal.MyExecuteNonQuery(sqlUpdateStock, CommandType.Text, ref error);
            }

            return false;
        }

        public override bool Update(OrderDetail entity, ref string error)
        {
            string sql = $"UPDATE OrderDetails SET ProductID='{entity.ProductID}', Quantity={entity.Quantity} " +
                         $"WHERE OrderDetailID='{entity.OrderDetailID}'";
            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        public override bool Delete(object id, ref string error)
        {
            string sql = $"DELETE FROM OrderDetails WHERE OrderDetailID = '{id}'";
            return dal.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }
    }
}