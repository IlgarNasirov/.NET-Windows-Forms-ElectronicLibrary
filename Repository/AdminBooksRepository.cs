using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using ElectronicLibrary.IRepository;

namespace ElectronicLibrary.Repository
{
    public class AdminBooksRepository : IAdminBooksRepository
    {
        string sql;
        DbHelper dbHelper = new DbHelper();
        List<SqlParameter> list;

        public DataTable AdminAllBook()
        {
            sql = "select id, category, name, author, YEAR(publish_year) as publish_year, status from [book]";
            list = new List<SqlParameter>();
            return dbHelper.ExecuteReader(sql, list);
        }

        public int AdminDeleteBook(int id)
        {
            sql = "delete from [book] where id=@ID";
            list = new List<SqlParameter>() { new SqlParameter("@ID", id) };
            return dbHelper.ExecuteNonQuery(sql, list);
        }
        public DataTable AdminFindBookNameAuthor(string value)
        {
            sql = "select id, category, name, author, YEAR(publish_year) as publish_year, status from [book] where name like @NAME or author like @AUTHOR";
            list = new List<SqlParameter>()
            {
                new SqlParameter("@NAME", value+'%'),
                new SqlParameter("@AUTHOR", value+'%')
            };
            return dbHelper.ExecuteReader(sql, list);
        }
        public DataTable AdminAllCategory()
        {
            sql = "select * from [category]";
            list = new List<SqlParameter>();
            return dbHelper.ExecuteReader(sql, list);
        }
        public DataTable AdminFindBookCategory(string value)
        {
            sql = "select id, category, name, author, YEAR(publish_year) as publish_year, status from [book] where category=@CATEGORY";
            list = new List<SqlParameter>() { new SqlParameter("@CATEGORY", value) };
            return dbHelper.ExecuteReader(sql, list);
        }
    }
}
