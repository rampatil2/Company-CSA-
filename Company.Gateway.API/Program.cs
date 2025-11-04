using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace Company.Gateway.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Configuration.AddJsonFile("ocelot.json",optional:false, reloadOnChange:true);
            builder.Services.AddOcelot(builder.Configuration);

            builder.Services.AddCors(options=>options.AddDefaultPolicy(policy=>policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();
            app.UseCors();
            await app.UseOcelot();
            app.UseAuthorization();
            

            app.MapControllers();

            app.Run();
        }
    }
}
