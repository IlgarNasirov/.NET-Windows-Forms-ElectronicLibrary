using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using ElectronicLibrary.IRepository;

namespace ElectronicLibrary.Repository
{
    public class AdminUsersRepository : IAdminUsersRepository
    {
        string sql;
        DbHelper dbHelper = new DbHelper();
        public DataTable AdminAllUser()
        {
            sql = "select * from [user] where isadmin=0";
            List<SqlParameter> list = new List<SqlParameter>();
            return dbHelper.ExecuteReader(sql, list);
        }
        public DataTable AdminAllUserCard(string uname)
        {
            sql = "select * from [report] where username=@USERNAME";
            List<SqlParameter> list = new List<SqlParameter>() { new SqlParameter("@USERNAME", uname) };
            return dbHelper.ExecuteReader(sql, list);
        }
        public int AdminDeleteUser(int id)
        {
            sql = "delete from [user] where id=@ID";
            List<SqlParameter> list = new List<SqlParameter>() { new SqlParameter("@ID", id) };
            return dbHelper.ExecuteNonQuery(sql, list);
        }
    }
}
