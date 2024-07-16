using AutoMapper;
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
    }
}
