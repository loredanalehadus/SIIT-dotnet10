using AutoMapper;
using FluentAssertions;
using Moq;
using Store.Entities;
using Store.Models;
using Store.Repositories;
using Store.Services;

namespace Store.UnitTests
{
    public class CategoryServiceTests
    {
        private readonly Mock<ICategoryRepository> mockRepository;
        private readonly Mock<IMapper> mockMapper;
        private CategoryService sut;

        public CategoryServiceTests()
        {
            mockRepository = new Mock<ICategoryRepository>(/*MockBehavior.Strict*/);
            mockMapper = new Mock<IMapper>();

            sut = new CategoryService(mockRepository.Object, mockMapper.Object);
        }

        [Fact]
        public void Add_WhenDuplicateCategoryName_ShouldReturnNull()
        {
            // Arrange
            mockRepository.Setup(x => x.IsDuplicateCategoryName(It.IsAny<string>())).Returns(true);

            // Act
            var result = sut.Add(CategoryModelData);

            // Assert
            result.Should().BeNull();
        }

        [Fact]
        public void Add_WhenUniqueCategoryName_ShouldReturnCategoryModel()
        {
            var category = new Category { Categoryid = 1 };
            var addedCategory = new Category();
            var expected = new CategoryModel();

            //mockRepository.Setup(x => x.IsDuplicateCategoryName(It.IsAny<string>())).Returns(false);
            //mockMapper.Setup(m => m.Map<Category>(It.IsAny<CategoryModel>())).Returns(category);
            //mockRepository.Setup(m => m.Add(It.IsAny<Category>())).Returns(addedCategory);

            mockMapper.Setup(m => m.Map<CategoryModel>(It.IsAny<Category>())).Returns(expected);

            var result = sut.Add(CategoryModelData);

            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(expected);
        }

        private CategoryModel CategoryModelData => new CategoryModel
        {
            Categoryid = 1,
            CategoryName = "category test",
            Description = "description"
        };
    }
}
