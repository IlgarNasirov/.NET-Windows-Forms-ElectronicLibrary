namespace ElectronicLibrary.IRepository
{
    public interface IAdminAddUserRepository
    {
        int AdminAddUser(Entity.User user);
        int AdminUpdateUser(Entity.User user);
    }
}
