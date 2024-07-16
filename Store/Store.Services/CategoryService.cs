﻿using AutoMapper;
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

        public Category Update(CategoryModel categoryModel)
        {
            var categoryToUpdate = mapper.Map<Category>(categoryModel);
            return categoryRepository.Update(categoryToUpdate);
        }

        public bool Delete(int id)
        {
            var itemsToDelete = categoryRepository.GetCategoryWithProducts(id);

            if (itemsToDelete != null)
            {
                //don't delete items if they have products
                if(itemsToDelete.Products.Count > 0)
                {
                    return false;
                }
            }

            var deleted = categoryRepository.Delete(itemsToDelete);

            return deleted;
        }

        public bool CheckIfExists(int id)
        {
            // call methods from repository
            throw new NotImplementedException();
        }
    }
}
