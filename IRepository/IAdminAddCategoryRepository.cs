

using ElectronicLibrary.Entity;

namespace ElectronicLibrary.IRepository
{
    public interface IAdminAddCategoryRepository
    {
        int AdminAddCategory(Category category);
        int AdminUpdateCategory(Category category);
    }
}
