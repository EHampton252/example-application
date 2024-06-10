using SchoolSystem.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace SchoolSystem.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            AddSwaggerGen(builder);
            AddDbContext(builder);
            RunApp(builder);
            
        }

        // public static void CheckConfigurationKeys(WebApplicationBuilder builder)

        private static void AddSwaggerGen(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
        }

        // Add our DB context to the services collection
        private static void AddDbContext(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<SchoolSystemContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolContext")));
        }

        // private static void AddServices(WebApplicationBuilder builder)

        private static void RunApp(WebApplicationBuilder builder)
        {
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            // NOTE: This order is important, see https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
