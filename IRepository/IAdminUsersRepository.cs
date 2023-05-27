using System.Data;

namespace ElectronicLibrary.IRepository
{
    public interface IAdminUsersRepository
    {
        DataTable AdminAllUser();
        DataTable AdminAllUserCard(string uname);
        int AdminDeleteUser(int id);
    }
}
