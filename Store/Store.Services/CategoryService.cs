using AutoMapper;
using Store.Entities;
using Store.Models;
using Store.Repositories;

namespace Store.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository categoryRepository;
        private IMapper mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            var categories = categoryRepository.GetAll();
            var categoryModels = mapper.Map<List<CategoryModel>>(categories);

            return categoryModels;
        }

        public Category Add(CategoryModel categoryModel)
        {
            // transformam modelul in entitate de db
            // adaugam in db

            var categoryToAdd = mapper.Map<Category>(categoryModel);
            return categoryRepository.Add(categoryToAdd);
        }
    }
}
