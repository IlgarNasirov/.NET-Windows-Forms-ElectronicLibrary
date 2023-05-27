using ElectronicLibrary.IRepository;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ElectronicLibrary.Repository
{
    public class AdminAddBookRepository : IAdminAddBookRepository
    {
        DbHelper dbHelper = new DbHelper();
        string sql;
        List<SqlParameter> list;
        public int AdminAddBook(Book book)
        {
            sql = "insert into [book] (name, author, publish_year, category) values (@NAME, @AUTHOR, @PUBLISH, @CATEGORY)";
            list = new List<SqlParameter>()
            {
                new SqlParameter("@NAME", book.Name),
                new SqlParameter("@AUTHOR", book.Author),
                new SqlParameter("@PUBLISH", book.Publish_year),
                new SqlParameter("@CATEGORY", book.Category)
            };
            return dbHelper.ExecuteNonQuery(sql, list);
        }
        public int AdminUpdateBook(Book book)
        {
            sql = "update [book] set name=@NAME, author=@AUTHOR, publish_year=@PUBLISH, category=@CATEGORY where id=@ID";
            list = new List<SqlParameter>()
            {

                new SqlParameter("@NAME", book.Name),
                new SqlParameter("@AUTHOR", book.Author),
                new SqlParameter("@PUBLISH", book.Publish_year),
                new SqlParameter("@CATEGORY", book.Category),
                new SqlParameter("@ID",book.Id)
            };
            return dbHelper.ExecuteNonQuery(sql, list);
        }
    }
}
