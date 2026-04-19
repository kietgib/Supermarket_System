using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketSystem.DataLayer
{
    public class DataAccessLayer
    {

        string ConnStr = "Data Source=TUILATHANH\\SQLEXPRESS;Initial Catalog=SupermarketDB;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DataAccessLayer()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, SqlParameter[] parameters)
        {
            comm.Parameters.Clear();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;

            if (parameters != null)
            {
                comm.Parameters.AddRange(parameters);
            }

            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, SqlParameter[] parameters = null)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear(); // QUAN TRỌNG: Xóa tham số cũ
            comm.CommandText = strSQL;
            comm.CommandType = ct;

            // Thêm các tham số mới nếu có
            if (parameters != null)
            {
                comm.Parameters.AddRange(parameters);
            }

            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        internal bool MyExecuteNonQuery(string sql, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = sql;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        public DataSet SearchCustomers(string ID, string name, string phone, string address)
        {
            string sql = "SELECT * FROM Customers WHERE Status = 1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(name))
            {
                sql += " AND Name LIKE @name";
                parameters.Add(new SqlParameter("@name", "%" + name + "%"));
            }

            if (!string.IsNullOrEmpty(ID))
            {
                sql += " AND CustomerID LIKE @ID";
                parameters.Add(new SqlParameter("@ID", "%" + ID + "%"));
            }

            if (!string.IsNullOrEmpty(phone))
            {
                sql += " AND Phone LIKE @phone";
                parameters.Add(new SqlParameter("@phone", "%" + phone + "%"));
            }

            if (!string.IsNullOrEmpty(address))
            {
                sql += " AND Address LIKE @address";
                parameters.Add(new SqlParameter("@address", "%" + address + "%"));
            }

            return ExecuteQueryDataSet(sql, CommandType.Text, parameters.ToArray());
        }

        public DataSet SearchOrderDetails(string orderID, string orderDetailID, string productID, string unitPrice, string quantity, string totalAmount)
        {
            // Câu lệnh gốc (giả sử bảng tên là OrderDetails)
            string sql = "SELECT * FROM OrderDetails WHERE Status = 1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(orderID))
            {
                sql += " AND OrderID LIKE @orderID";
                parameters.Add(new SqlParameter("@orderID", "%" + orderID + "%"));
            }

            if (!string.IsNullOrEmpty(orderDetailID))
            {
                sql += " AND OrderDetailID LIKE @orderDetailID";
                parameters.Add(new SqlParameter("@orderDetailID", "%" + orderDetailID + "%"));
            }

            if (!string.IsNullOrEmpty(productID))
            {
                sql += " AND ProductID LIKE @productID";
                parameters.Add(new SqlParameter("@productID", "%" + productID + "%"));
            }

            //if (!string.IsNullOrEmpty(unitPrice))
            //{
            //    sql += " AND UnitPrice LIKE @unitPrice";
            //    parameters.Add(new SqlParameter("@unitPrice", "%" + unitPrice + "%"));
            //}

            //if (!string.IsNullOrEmpty(quantity))
            //{
            //    sql += " AND Quantity LIKE @quantity";
            //    parameters.Add(new SqlParameter("@quantity", "%" + quantity + "%"));
            //}

            //if (!string.IsNullOrEmpty(totalAmount))
            //{
            //    sql += " AND TotalAmount LIKE @totalAmount";
            //    parameters.Add(new SqlParameter("@totalAmount", "%" + totalAmount + "%"));
            //}

            sql += BuildNumberFilter("UnitPrice", unitPrice, parameters);
            sql += BuildNumberFilter("Quantity", quantity, parameters);
            sql += BuildNumberFilter("TotalAmount", totalAmount, parameters);

            return ExecuteQueryDataSet(sql, CommandType.Text, parameters.ToArray());
        }

        public DataSet SearchOrders(string orderID, string customerID, string orderDate)
        {
            // 1=1 giúp việc cộng chuỗi "AND" trở nên dễ dàng hơn
            string sql = "SELECT * FROM Orders WHERE Status = 1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(orderID))
            {
                sql += " AND OrderID LIKE @orderID";
                parameters.Add(new SqlParameter("@orderID", "%" + orderID + "%"));
            }

            if (!string.IsNullOrEmpty(customerID))
            {
                sql += " AND CustomerID LIKE @customerID";
                parameters.Add(new SqlParameter("@customerID", "%" + customerID + "%"));
            }

            if (!string.IsNullOrEmpty(orderDate))
            {
                // Với ngày tháng, LIKE sẽ tìm kiếm theo định dạng chuỗi lưu trong DB
                sql += " AND OrderDate LIKE @orderDate";
                parameters.Add(new SqlParameter("@orderDate", "%" + orderDate + "%"));
            }

            return ExecuteQueryDataSet(sql, CommandType.Text, parameters.ToArray());
        }





        public DataSet SearchProducts(string productID, string categoryID, string name, string price, string stock)
        {
            string sql = "SELECT * FROM Products WHERE Status = 1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Tìm kiếm chuỗi (LIKE)
            if (!string.IsNullOrEmpty(productID))
            {
                sql += " AND ProductID LIKE @productID";
                parameters.Add(new SqlParameter("@productID", "%" + productID + "%"));
            }
            if (!string.IsNullOrEmpty(categoryID))
            {
                sql += " AND CategoryID LIKE @categoryID";
                parameters.Add(new SqlParameter("@categoryID", "%" + categoryID + "%"));
            }
            if (!string.IsNullOrEmpty(name))
            {
                sql += " AND Name LIKE @name";
                parameters.Add(new SqlParameter("@name", "%" + name + "%"));
            }

            // Tìm kiếm số theo khoảng (Price và Stock)
            sql += BuildNumberFilter("Price", price, parameters);
            sql += BuildNumberFilter("StockQuantity", stock, parameters);

            return ExecuteQueryDataSet(sql, CommandType.Text, parameters.ToArray());
        }

        // Hàm phụ để xử lý dấu >, <, >=, <=
        private string BuildNumberFilter(string columnName, string input, List<SqlParameter> parameters)
        {
            if (string.IsNullOrEmpty(input)) return "";

            string op = "="; // Mặc định là bằng
            string value = input;

            if (input.StartsWith(">=")) { op = ">="; value = input.Substring(2); }
            else if (input.StartsWith("<=")) { op = "<="; value = input.Substring(2); }
            else if (input.StartsWith(">")) { op = ">"; value = input.Substring(1); }
            else if (input.StartsWith("<")) { op = "<"; value = input.Substring(1); }

            // Kiểm tra xem phần còn lại có phải là số không để tránh lỗi SQL
            if (double.TryParse(value, out double num))
            {
                string paramName = "@" + columnName;
                parameters.Add(new SqlParameter(paramName, num));
                return $" AND {columnName} {op} {paramName}";
            }
            return "";
        }




        public DataSet SearchStaff(string employeeID, string name, string phone, string position)
        {
            // Bắt đầu với câu lệnh lấy tất cả nhân viên đang làm việc (Status = 1)
            string sql = "SELECT * FROM Employees WHERE Status = 1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(employeeID))
            {
                sql += " AND EmployeeID LIKE @employeeID";
                parameters.Add(new SqlParameter("@employeeID", "%" + employeeID + "%"));
            }

            if (!string.IsNullOrEmpty(name))
            {
                sql += " AND Name LIKE @name";
                parameters.Add(new SqlParameter("@name", "%" + name + "%"));
            }

            if (!string.IsNullOrEmpty(phone))
            {
                sql += " AND Phone LIKE @phone";
                parameters.Add(new SqlParameter("@phone", "%" + phone + "%"));
            }

            if (!string.IsNullOrEmpty(position))
            {
                sql += " AND Position LIKE @position";
                parameters.Add(new SqlParameter("@position", "%" + position + "%"));
            }
            return ExecuteQueryDataSet(sql, CommandType.Text, parameters.ToArray());
        }

    }
}
