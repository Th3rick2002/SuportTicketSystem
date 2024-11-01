using CommonLayer.Entities;

namespace DataAccessLayer.Repositories;

public interface ICategoriesrepository
{
    List<Categories> GetAllCategories();
    void AddCategory(Categories category);
    void UpdateCategory(Categories category);
    void DeleteCategory(Categories category);
}