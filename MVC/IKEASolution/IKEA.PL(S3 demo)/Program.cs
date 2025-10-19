using IKEA.BLL.Services;
using IKEA.DAL.Contexts;
using IKEA.DAL.Reposatories.DepartmentRepo;
using Microsoft.EntityFrameworkCore;

namespace IKEA.PL_S3_demo_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ApplicationDBContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            builder.Services.AddScoped<IDepartmentReposatery, DepartmentRepostories>();
            builder.Services.AddScoped<IDepartmentInterface , DepartmentService>();

            var app = builder.Build();

            

            app.UseHttpsRedirection();
            app.UseRouting();

           

            app.UseStaticFiles();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
                

            app.Run();
        }
    }
}
