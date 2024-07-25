using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Store.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.IntegrationTests
{
    // configurat Test Serverul nostru
    public class StoreApiFactory<TProgram> : WebApplicationFactory<TProgram> where TProgram : class
    {
        private const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Store.Test";

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.UseEnvironment("Test");

            builder.ConfigureTestServices(services =>
            {
                var dbContextDescriptor = services.SingleOrDefault(
                    d => d.ServiceType == typeof(DbContextOptions<StoreContext>));
                services.Remove(dbContextDescriptor);

                // register new context for a testing database
                services.AddDbContext<StoreContext>(options =>
                {
                    options.UseSqlServer(ConnectionString);
                    options.EnableSensitiveDataLogging();
                });

                // add HTTP client -> simulate the HTTP request we do using swagger
                services.AddHttpClient("local", httpClient =>
                {
                    httpClient.BaseAddress = new Uri("https://localhost:7068/api/");
                });
            });

            builder.UseTestServer();
        }
    }
}
