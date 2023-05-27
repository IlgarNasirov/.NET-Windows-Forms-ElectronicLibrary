using ElectronicLibrary.IRepository;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ElectronicLibrary.Repository
{
    public class LoginRepository : ILoginRepository
    {
        public int Login(Entity.User user)
        {
            string query = "select id from [user] where username=@USERNAME and password=@PASSWORD and isadmin=@ISADMIN";
            List<SqlParameter> list = new List<SqlParameter>()
            {
                new SqlParameter("@USERNAME",user.Username),
                new SqlParameter("@PASSWORD",user.Password),
                new SqlParameter("@ISADMIN",user.IsAdmin)
            };
            DbHelper dbHelper = new DbHelper();
            double result = dbHelper.ExecuteScalar(query, list);
            if (result > 0)
            {
                if (user.IsAdmin)
                    return 1;
                return 0;
            }
            return -1;
        }
    }
}
