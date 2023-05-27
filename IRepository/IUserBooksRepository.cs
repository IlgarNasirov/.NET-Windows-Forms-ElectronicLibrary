using ElectronicLibrary.Entity;
using System.Data;

namespace ElectronicLibrary.IRepository
{
    public interface IUserBooksRepository
    {
        DataTable UserAllBook();
        DataTable UserFindBookNameAuthor(string value);
        DataTable UserAllCategory();
        DataTable UserFindBookCategory(string value);
        int UserAddUserCard(Report report);
    }
}
