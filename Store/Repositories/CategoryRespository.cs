using Store.Controllers;
using Store.Data;
using Store.Entities;

namespace Store.Repositories
{
    public class CategoryRespository : ICategoryRespository
    {
        private readonly StoreContext storeContext;

        public CategoryRespository(StoreContext storeContext)
        {
            this.storeContext = storeContext;
        }

        public IEnumerable<Category> GetAll()
        {
            return storeContext.Categories;
        }
    }
}
