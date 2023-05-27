using ElectronicLibrary.Entity;
using ElectronicLibrary.IRepository;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ElectronicLibrary.Repository
{
    public class UserUserCardRepository : IUserUserCardRepository
    {
        string sql;
        DbHelper dbHelper=new DbHelper();
        List<SqlParameter> list;
        public DataTable UserAllUserCard(bool isChecked, string username)
        {
            if(isChecked)
            {
                sql = "select r.id as id, username, book_id, name, category , author, receive_date, deadline, return_date, fine, r.status as status from [report] r inner join [book] b on r.book_id=b.id where username=@USERNAME";
            }
            else
                sql = "select r.id as id, username, book_id, name, category , author, receive_date, deadline, return_date, fine, r.status as status from [report] r inner join [book] b on r.book_id=b.id where r.status=1 and username=@USERNAME";
            list = new List<SqlParameter>() { new SqlParameter("@USERNAME", username) };
            return dbHelper.ExecuteReader(sql, list);
        }
        public int UserReturnBook(Report report)
        {
            sql = "update [book] set status=1 where id=@ID";
            list = new List<SqlParameter>
            {
                new SqlParameter("@ID",report.Book_id)
            };
            dbHelper.ExecuteNonQuery(sql, list);
            sql = "update [report] set return_date=@RETURN_DATE, fine=@FINE, status=0 where id=@ID and status=1";
            list = new List<SqlParameter>()
            {
                new SqlParameter("@RETURN_DATE", report.Return_date),
                new SqlParameter("@FINE", report.Fine),
                new SqlParameter("@ID", report.Id)
            };
            return dbHelper.ExecuteNonQuery(sql, list);
        }
    }
}
