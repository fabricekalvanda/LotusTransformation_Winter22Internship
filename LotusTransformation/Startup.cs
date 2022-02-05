using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LotusTransformation.Services;
using LotusTransformation.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;


namespace LotusTransformation
{
    public class Startup
    {
        private readonly IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration; ;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddControllersWithViews();
            services.AddScoped<LogIn>();
            services.AddMvcCore();
            services.AddDbContext<LotusTransformationContext>(options => options.UseSqlServer(configuration.GetConnectionString("LotusTransformationDb")));
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}",
                    defaults: new
                    {
                        controller = "LotusGeneral",
                        action = "Home"
                    });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "CreateAccount",
                    pattern: "{controller}/{action}",
                    defaults: new
                    {
                        controller = "CreateAccount",
                        action = "CreateAccount"
                    });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "SignIn",
                    pattern: "{controller}/{action}",
                    defaults: new
                    {
                        controller = "SignIn",
                        action = "SignIn"
                    });
            });


        }
    }
}
