using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wtow.Data;
using Wtow.Domain;
using Wtow.Service;

namespace Wtow.Web
{
    public class Startup
    {
        public IConfiguration _config { get; }

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddIdentity<AppUser, IdentityRole>(cfg =>
            {
                cfg.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<TitleContext>();
            

            services.AddDbContext<TitleContext>(cfg => cfg.UseSqlServer(_config.GetConnectionString("Wtow")));
            services.AddTransient<ITitleService, TitleService>();

            services.AddTransient<TitleSeeder>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });


            if (env.IsDevelopment())
            {
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var seeder = scope.ServiceProvider.GetService<TitleSeeder>();
                    seeder.Seed().Wait();
                }
            }
        }
    }
}
