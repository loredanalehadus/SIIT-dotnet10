using Store.Data;
using Store.Entities;

namespace Store.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreContext storeContext;

        public CategoryRepository(StoreContext storeContext)
        {
            this.storeContext = storeContext;
        }

        public IEnumerable<Category> GetAll()
        {
            return storeContext.Categories;
        }
    }
}
