

namespace ElectronicLibrary.IRepository
{
    public interface IAdminAddBookRepository
    {
        int AdminAddBook(Book book);
        int AdminUpdateBook(Book book);
    }
}
