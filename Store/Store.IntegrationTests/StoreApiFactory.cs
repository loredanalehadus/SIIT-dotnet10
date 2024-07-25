using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Store.Data;

namespace Store.IntegrationTests
{
    public class StoreApiFactory<TProgram> : WebApplicationFactory<TProgram> where TProgram : class
    {
        private const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Store.Test";

        public StoreApiFactory()
        {
        }
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.UseEnvironment("Test");

            builder.ConfigureTestServices(services =>
            {
                var dbContextDescriptor = services.SingleOrDefault(
                d => d.ServiceType == typeof(DbContextOptions<StoreContext>));
                services.Remove(dbContextDescriptor);

                services.AddDbContext<StoreContext>(options =>
                {
                    options.UseSqlServer(ConnectionString);
                    options.EnableSensitiveDataLogging();
                });

                services.AddHttpClient("local", httpClient =>
                {
                    httpClient.BaseAddress = new Uri("https://localhost:7068/api/");
                });
            });

            builder.UseTestServer();

        }
    }



}