using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using FootballCalc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.InMemory;

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
            services.AddMvc();

            services.AddDbContext<DbApiContext>(opt => opt.UseInMemoryDatabase(databaseName: "InMemoryDb"));

            //services.AddDbContext<ApplicationDbContext>(options =>
            //options.UseSqlServer(Configuration["ConnectionStrings:FootballCalcContext"]));
            //services.AddTransient<IFootballRepository>();

            ////services.AddDbContext<FootballCalcContext>(options =>
            ////        options.UseSqlServer(Configuration.GetConnectionString("FootballCalcContext")));
            ////services.AddTransient<IFootballRepository, FakeFootballRepository>();
            ////services.AddMvc();
            
            
            services.AddDistributedMemoryCache();
            //services.AddScoped<Players>(sp => SessionPlayer.GetPlayers(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMemoryCache();
            services.AddSession();
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
            app.UseSession();
            app.UseRouting();
            app.UseAuthorization();

            var context = app.ApplicationServices.GetService<DbApiContext>();
            AddTestData(context);

            //app.UseMvc(routes => {
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Register}/{action=Userlist}/{id?}");
            //});
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private static void AddTestData(DbApiContext context)
        {
            var player = new Players
            {
                PlayerID = 1,
                PlayerName = "Bob",
                PlayerPosition = 0,
                PlayerSalary = 2,
                PlayerTeam = "Llamas"
            };

            context.Players.Add(player);

            player = new Players
            {
                PlayerID = 2,
                PlayerName = "Frank",
                PlayerPosition = 0,
                PlayerSalary = 3,
                PlayerTeam = "Penguins"
            };
            context.Players.Add(player);
            context.SaveChanges();
        }

    }
}
