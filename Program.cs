using Microsoft.EntityFrameworkCore;
using RostrosFelices.Data;

namespace RostrosFelices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

          
            builder.Services.AddRazorPages();
            builder.Services.AddAuthentication().AddCookie("MyCookieAuth", options =>
            {
                options.Cookie.Name = "MyCookieAuth";
                options.LoginPath = "/Account/Register";
                options.LoginPath = "/Account/Login";
            }
           );

            builder.Services.AddDbContext<RostrosFelicesContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BaseDeDatosApp")));

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}