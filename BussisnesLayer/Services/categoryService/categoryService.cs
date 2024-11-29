using CommonLayer.Entities;
using DataAccessLayer.Repositories;

namespace BussisnesLayer.Services.categoryService;

public class CategoryService: ICategoryService
{
    private readonly Categoriesrepository _categoriesrepository;

    public CategoryService()
    {
        _categoriesrepository = new Categoriesrepository();
    }
    
    public List<Categories> GetAllCategories()
    {
        return _categoriesrepository.GetAllCategories();
    }

    public void AddCategory(Categories category)
    {
        _categoriesrepository.AddCategory(category);
    }

    public void UpdateCategory(Categories category)
    {
        _categoriesrepository.UpdateCategory(category);
    }

    public void DeleteCategory(Categories category)
    {
        _categoriesrepository.DeleteCategory(category);
    }
}