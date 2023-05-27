using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using ElectronicLibrary.IRepository;

namespace ElectronicLibrary.Repository
{
    public class AdminCategoriesRepository : IAdminCategoriesRepository
    {
        string sql;
        DbHelper dbHelper = new DbHelper();

        public DataTable AdminAllCategory()
        {
            sql = "select * from [category]";
            List<SqlParameter> list = new List<SqlParameter>();
            return dbHelper.ExecuteReader(sql, list);
        }

        public int AdminDeleteCategory(int id)
        {
            sql = "delete from [category] where id=@ID";
            List<SqlParameter> list = new List<SqlParameter>() { new SqlParameter("@ID", id) };
            return dbHelper.ExecuteNonQuery(sql, list);
        }
    }
}
