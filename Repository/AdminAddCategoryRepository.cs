using ElectronicLibrary.Entity;
using ElectronicLibrary.IRepository;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ElectronicLibrary.Repository
{
    public class AdminAddCategoryRepository : IAdminAddCategoryRepository
    {
        DbHelper dbHelper = new DbHelper();
        string sql;
        List<SqlParameter> list;
        public int AdminAddCategory(Category category)
        {
            sql = "insert into [category] (name) values (@NAME)";
            list = new List<SqlParameter>()
            {
                new SqlParameter("@NAME", category.Name)

            };
            return dbHelper.ExecuteNonQuery(sql, list);
        }
        public int AdminUpdateCategory(Category category)
        {
            sql = "update [category] set name=@NAME where id=@ID";
            list = new List<SqlParameter>()
            {
                new SqlParameter("@NAME", category.Name),
                new SqlParameter("@ID",category.Id)
            };
            return dbHelper.ExecuteNonQuery(sql, list);
        }
    }
}
