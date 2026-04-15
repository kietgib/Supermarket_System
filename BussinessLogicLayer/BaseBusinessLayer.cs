using SupermarketSystem.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SupermarketSystem.DataLayer.DataAccessLayer;
using SupermarketSystem.BussinessLogicLayer.Entities;
using SupermarketSystem.BussinessLogicLayer;

namespace SupermarketSystem.BussinessLogicLayer
{
    public abstract class BaseBusinessLogic<T> where T : class
    {
        // Sử dụng tầng DataAccessLayer đã khai báo ở trên
        protected DataLayer.DataAccessLayer dal = new DataLayer.DataAccessLayer();


        // Lấy tất cả dữ liệu (Cần một tham số tên bảng hoặc Query)
        public abstract DataSet GetAll();

        // Các hàm CRUD chung
        public abstract bool Add(T entity, ref string error);
        public abstract bool Update(T entity, ref string error);
        public abstract bool Delete(object id, ref string error);

        // Logic Validation chung
        protected virtual bool ValidateEntity(T entity)
        {
            return entity != null;
        }
    }
}
