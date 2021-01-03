using AutoMapper;
using Library.Data;
using Library.Models.Mapping;
using Library.Service;
using Library.Service.Helpers;
using Library.Service.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Library
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddSingleton(Configuration);
            services.AddScoped<ILibraryCardService, LibraryCardService>();
            services.AddScoped<ILibraryBranchService, LibraryBranchService>();
            services.AddScoped<IPatronService, PatronService>();
            services.AddScoped<ICheckoutService, CheckoutService>();
            services.AddScoped<ILibraryAssetService, LibraryAssetService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IVideoService, VideoService>();
            services.AddScoped<IStatusService, StatusService>();
           
            services.AddScoped(typeof(IPaginator<>), typeof(Paginator<>));

            services.AddDbContext<LibraryDbContext>(options 
                => options.UseSqlServer(Configuration.GetConnectionString("LibraryConnection")));

            services.AddAutoMapper(c => c.AddProfile<EntityMappingProfile>(), typeof(Startup));      
        }


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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
