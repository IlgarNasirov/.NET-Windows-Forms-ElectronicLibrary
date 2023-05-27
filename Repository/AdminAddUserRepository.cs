using ElectronicLibrary.IRepository;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ElectronicLibrary.Repository
{
    public class AdminAddUserRepository : IAdminAddUserRepository
    {
        DbHelper dbHelper = new DbHelper();
        string sql;
        List<SqlParameter> list;
        public int AdminAddUser(Entity.User user)
        {
            sql = "insert into [user] (username, password, full_name, phone, address) values (@USERNAME, @PASSWORD, @FULLNAME, @PHONE, @ADDRESS)";
            list = new List<SqlParameter>()
            {
                new SqlParameter("@USERNAME", user.Username),
                new SqlParameter("@PASSWORD", user.Password),
                new SqlParameter("@FULLNAME", user.Fullname),
                new SqlParameter("@PHONE", user.Phone),
                new SqlParameter("@ADDRESS", user.Address)
            };
            return dbHelper.ExecuteNonQuery(sql, list);
        }
        public int AdminUpdateUser(Entity.User user)
        {
            sql = "update [user] set username=@USERNAME, password=@PASSWORD, full_name=@FULLNAME, phone=@PHONE, address=@ADDRESS where id=@ID";
            list = new List<SqlParameter>()
            {
                new SqlParameter("@USERNAME", user.Username),
                new SqlParameter("@PASSWORD", user.Password),
                new SqlParameter("@FULLNAME", user.Fullname),
                new SqlParameter("@PHONE", user.Phone),
                new SqlParameter("@ADDRESS", user.Address),
                new SqlParameter("@ID", user.Id)
            };
            return dbHelper.ExecuteNonQuery(sql, list);
        }
    }
}
