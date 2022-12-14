using BenfCompalintWeb.Areas.AdminGeneralFederation.Service;
using BenfCompalintWeb.Areas.UsersService.Model;
using BenfCompalintWeb.Areas.AdminService.Service;
using BenfCompalintWeb.Areas.Beneficiarie.Service;
using BenfCompalintWeb.Areas.Beneficiaries.Data.Base;
using BenfCompalintWeb.Areas.VillagesUsers.Service;
using BenfCompalintWeb.Models;
using BenfCompalintWeb.Models.Data.Base;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace BenfCompalintWeb
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
            services.AddControllersWithViews();

            services
    .AddDbContext<AppCompalintsContextDB>(
        b => b.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
              .UseLazyLoadingProxies());

            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {

            }).AddDefaultUI().AddEntityFrameworkStores<AppCompalintsContextDB>().AddDefaultTokenProviders();


            //services.AddDbContext<AppCompalintsContextDB>(options =>
            //{
            //    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            //});


            //services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            //{

            //}).AddDefaultUI().AddEntityFrameworkStores<AppCompalintsContextDB>().AddDefaultTokenProviders();

        
            // Add services to the container.

            services.AddScoped<ICompalintService, CompalintService>();
            services.AddScoped<IVillageService, VillageService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ILocationRepo<Governorate>, GovernorateRepo>();
            services.AddScoped<ILocationRepo<Directorate>, DirectorateRepo>();
            services.AddScoped<ILocationRepo<SubDirectorate>, SubDirectorateRepo>();
            services.AddScoped<ILocationRepo<Village>, VillageRepo>();
            services.AddAdminServices();






            //services.AddIdentity<ApplicationUser, IdentityRole>()
            //.AddEntityFrameworkStores<AppCompalintsContextDB>()
            //.AddDefaultUI()
            //.AddDefaultTokenProviders();
            services.AddControllersWithViews();
            // Add services to the container.



    //        services
    //.AddDbContext<ApplicationDbContext>(
    //    b => b.UseSqlServer(connectionString)
    //          .UseLazyLoadingProxies())
    //.AddDefaultIdentity<ApplicationUser>()
    //.AddEntityFrameworkStores<ApplicationDbContext>();



            services.AddAutoMapper(typeof(Startup));


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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseHttpsRedirection();
        
         

            app.UseEndpoints(endpoints =>
            {

              endpoints.MapControllerRoute(
               name: "Beneficiarie",
               pattern: "{area:exists}/{controller=Complaints}/{action=Index}/{id?}"
             );
              endpoints.MapControllerRoute(
              name: "AdminGeneralFederation",
              pattern: "{area:exists}/{controller=ManageCategoryes}/{action=Index}/{id?}"
            );
                


                endpoints.MapControllerRoute(
            name: "default",
            pattern: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
