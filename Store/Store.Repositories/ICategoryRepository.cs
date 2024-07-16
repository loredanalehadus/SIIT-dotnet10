using Store.Entities;

namespace Store.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
        Category Add(Category category);

    }
}
