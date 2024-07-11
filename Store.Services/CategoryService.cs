using Store.Entities;
using Store.Models;
using Store.Repositories;

namespace Store.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            var categories = categoryRepository.GetAll();

            var categoryModels = new List<CategoryModel>();

            foreach (var category in categories)
            {
                var model = new CategoryModel
                {
                    Categoryid = category.Categoryid,
                    CategoryName = category.Categoryname,
                    Description = category.Description
                };

                categoryModels.Add(model);
            }

            return categoryModels;
        }
    }
}
