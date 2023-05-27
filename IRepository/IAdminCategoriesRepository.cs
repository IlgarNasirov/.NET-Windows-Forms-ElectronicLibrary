using System.Data;

namespace ElectronicLibrary.IRepository
{
    public interface IAdminCategoriesRepository
    {
        DataTable AdminAllCategory();

        int AdminDeleteCategory(int id);
    }
}
