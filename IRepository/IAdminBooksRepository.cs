
using System.Data;

namespace ElectronicLibrary.IRepository
{
    public interface IAdminBooksRepository
    {
        DataTable AdminAllBook();
        int AdminDeleteBook(int id);
        DataTable AdminFindBookNameAuthor(string value);
        DataTable AdminAllCategory();
        DataTable AdminFindBookCategory(string value);
    }
}
