using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FootballCalc.Data;
using Microsoft.EntityFrameworkCore;
using FootballCalc.Models;
using Microsoft.AspNetCore.Mvc;

namespace FootballCalc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IFootballRepository, FakeFootballRepository>();
            services.AddMvc();
            //services.AddControllersWithViews();
            //services.AddDbContext<FootballCalcContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("FootballCalcContext")));
            //services.AddTransient<IFootballRepository>();

            ////services.AddDbContext<FootballCalcContext>(options =>
            ////        options.UseSqlServer(Configuration.GetConnectionString("FootballCalcContext")));
            ////services.AddTransient<IFootballRepository, FakeFootballRepository>();
            ////services.AddMvc();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //app.UseMvc(routes => {
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Register}/{action=Userlist}/{id?}");
            //});
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=List}/{id?}");
            });
        }
    }
}
