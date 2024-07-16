using Store.Entities;
using Store.Models;

namespace Store.Services
{
    public interface ICategoryService
    {
        IEnumerable<CategoryModel> GetAll();
        Category Add(CategoryModel categoryModel);

    }
}
