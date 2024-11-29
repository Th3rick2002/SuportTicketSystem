using CommonLayer.Entities;

namespace BussisnesLayer.Services.categoryService;

public interface ICategoryService
{
    public List<Categories> GetAllCategories();
    public void AddCategory(Categories category);
    public void UpdateCategory(Categories category);
    public void DeleteCategory(Categories category);
}