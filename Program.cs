using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using com.wendysa.apidemo.Repositories;

namespace com.wendysa.apidemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                            .UseKestrel()
                            .UseStartup<Program>()
                            .Build();
            host.Run(); 
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            
            // TODO: Should be configurable so that the demo supports more than one persistence products
            services.AddSingleton<IGamingPcRepository, com.wendysa.apidemo.Repositories.MongoDb.GamingPcRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvcWithDefaultRoute();
        }        
    }
}
