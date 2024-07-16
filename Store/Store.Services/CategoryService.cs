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
            var categoryToAdd = mapper.Map<Category>(categoryModel);
            return categoryRepository.Add(categoryToAdd);
        }

        public Category GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Category Update(Category category)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool CheckIfExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
