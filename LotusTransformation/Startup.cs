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
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace LotusTransformation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        { 
            this.Configuration = configuration; ;
        }

        private IConfiguration Configuration { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<LogIn>();
            services.AddMvcCore().AddRazorRuntimeCompilation();
            services.AddDbContext<LotusTransformationDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("LotusTransformationDb")));
            services.AddScoped<IAccountCreation, EFAccountCreation>();

            //2106109559544007
            //3df0dbc454ba97ac321e88c7eb92539c
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;

            })
            .AddCookie(options =>
              {
                  options.LoginPath = "/CreateAccount/AccountCreation";
              })
            .AddFacebook(options =>
            {
                options.AppId = "2106109559544007";
                options.AppSecret = "3df0dbc454ba97ac321e88c7eb92539c";
            });
            services.AddControllersWithViews();
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
            app.UseStatusCodePages();

            app.UseAuthentication();

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
