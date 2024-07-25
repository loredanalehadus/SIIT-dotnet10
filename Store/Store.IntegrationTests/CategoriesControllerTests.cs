using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using System.Net;

namespace Store.IntegrationTests
{
    public class CategoriesControllerTests : IClassFixture<StoreApiFactory<Program>>
    {
        private readonly HttpClient httpClient;
        public CategoriesControllerTests(StoreApiFactory<Program> appFactory)
        {
            appFactory.ClientOptions.BaseAddress = new Uri("https://localhost:7068/api/");
            this.httpClient = appFactory.CreateClient();
        }

        [Fact]
        public async Task Get_ReturnsNotFound_WhenCategoriesDoesNotExist()
        {
            //Arrange

            Random rnd = new Random();
            int ID = rnd.Next(10, 30);
            // Act
            var response = await httpClient.GetAsync($"categories/{ID}");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
            var problem = await response.Content.ReadFromJsonAsync<ValidationProblemDetails>();
            problem!.Title.Should().Be("Not Found");
            problem.Status.Should().Be(404);
        }
    }



}