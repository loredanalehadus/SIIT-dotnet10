using FluentAssertions;

namespace Store.IntegrationTests
{
    public class CategoriesControllerTests : IClassFixture<StoreApiFactory<Program>>
    {
        private readonly HttpClient httpClient;

        public CategoriesControllerTests(StoreApiFactory<Program> apiFactory)
        {
            apiFactory.ClientOptions.BaseAddress = new Uri("https://localhost:7068/api/");
            httpClient = apiFactory.CreateClient(); // new HttpClient()
        }

        [Fact]
        public async Task GetById_WhenCategoryDoesNotExist_ReturnsNotFoudnd()
        {
            // Assert
            var id = 54;

            // A
            var response = await httpClient.GetAsync($"categories/{id}"); // GET https://localhost:7068/api/categories/54

            // A
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.NotFound);
        }
    }
}