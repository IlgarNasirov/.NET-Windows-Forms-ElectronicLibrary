using ElectronicLibrary.Entity;
using System.Data;

namespace ElectronicLibrary.IRepository
{
    public interface IUserUserCardRepository
    {
        DataTable UserAllUserCard(bool isChecked, string username);
        int UserReturnBook(Report report);
    }
}
