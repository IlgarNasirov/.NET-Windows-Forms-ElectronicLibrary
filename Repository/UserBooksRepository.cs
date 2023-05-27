using ElectronicLibrary.Entity;
using ElectronicLibrary.IRepository;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ElectronicLibrary.Repository
{
    public class UserBooksRepository : IUserBooksRepository
    {
        string sql;
        DbHelper dbHelper=new DbHelper();
        List<SqlParameter> list;
        public DataTable UserAllBook()
        {
            sql = "select id, name, author, category, YEAR(publish_year) as publish_year, status from [book] where status=1";
            list = new List<SqlParameter>();
            return dbHelper.ExecuteReader(sql, list);
        }
        public DataTable UserFindBookNameAuthor(string value)
        {
            sql = "select id, name, author, category, YEAR(publish_year) as publish_year, status from [book] where name like @NAME or author like @AUTHOR and status=1";
            list = new List<SqlParameter>()
            {
                new SqlParameter("@NAME", value+'%'),
                new SqlParameter("@AUTHOR", value+'%')
            };
            return dbHelper.ExecuteReader(sql, list);
        }
        public DataTable UserAllCategory()
        {
            sql = "select * from [category]";
            list = new List<SqlParameter>();
            return dbHelper.ExecuteReader(sql, list);
        }
        public DataTable UserFindBookCategory(string value)
        {
            sql = "select id, name, author, category, YEAR(publish_year) as publish_year, status from [book] where category=@CATEGORY and status=1";
            list = new List<SqlParameter>() { new SqlParameter("@CATEGORY", value) };
            return dbHelper.ExecuteReader(sql, list);
        }
        public int UserAddUserCard(Report report)
        {
            sql = "update [book] set status=0 where id=@ID";
            list = new List<SqlParameter>() { new SqlParameter("@ID", report.Book_id) };
            dbHelper.ExecuteNonQuery(sql, list);
            sql = "insert into [report] (username, book_id, receive_date, deadline) values (@USERNAME, @BOOK_ID, @RECEIVE_DATE, @DEADLINE)";
            list = new List<SqlParameter>() 
            { 
                new SqlParameter("@USERNAME", report.Username),
                new SqlParameter("@BOOK_ID", report.Book_id),
                new SqlParameter("@RECEIVE_DATE", report.Receive_date),
                new SqlParameter("@DEADLINE", report.Deadline)
            };
            return dbHelper.ExecuteNonQuery(sql, list);
        }
    }
}
