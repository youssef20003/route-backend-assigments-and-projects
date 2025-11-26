using IKEA.BLL.Common.MappingProfiles;
using IKEA.BLL.Common.Services.Attachments;
using IKEA.BLL.Services.Department;
using IKEA.BLL.Services.EmployeeService;
using IKEA.BLL.Services.EmployeeServices;
using IKEA.DAL.Contexts;
using IKEA.DAL.Models.Auth;
using IKEA.DAL.Reposatories.DepartmentRepo;
using IKEA.DAL.Reposatories.EmployeeRepo;
using IKEA.DAL.UOW;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IKEA.PL_S3_demo_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(options =>
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute()));
            builder.Services.AddDbContext<ApplicationDBContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                options.UseLazyLoadingProxies();
            });

            builder.Services.AddScoped<IUOW , UnitOfWork>();
            //builder.Services.AddScoped<IDepartmentReposatery, DepartmentRepostories>();
            builder.Services.AddScoped<IDepartmentInterface , DepartmentService>();

            //builder.Services.AddScoped<IEmployeeRepo, EmployeRepo>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();

            builder.Services.AddScoped<IAttachmentService, AtachmentService>();

            builder.Services.AddAutoMapper(m => m.AddMaps(typeof(ProjectMappingProfile).Assembly));

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
                {
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;

                })
                .AddEntityFrameworkStores<ApplicationDBContext>()
                .AddDefaultTokenProviders();

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Account/Login";
                    options.AccessDeniedPath = "/Account/AccessDenied";
                    options.ExpireTimeSpan = TimeSpan.FromHours(2);
                });

            var app = builder.Build();

            

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseStaticFiles();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
                

            app.Run();
        }
    }
}
