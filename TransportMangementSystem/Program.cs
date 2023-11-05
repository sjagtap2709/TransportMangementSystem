
using Microsoft.EntityFrameworkCore;
using TMSDataAccessLayer;
using TMSDataAccessLayer.DataComponents;
using TMSDataAccessLayer.DBContext;
using TMSDataAccessLayer.IDataComponents;

namespace TransportMangementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<TransportMgtContext>(option =>
            {
                option.UseSqlServer("Server=.\\SQLExpress;Database=TransportMgt;Trusted_Connection=True; TrustServerCertificate=True;");
            });
            builder.Services.AddConfigureServices();
            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action=Index}/{id?}");

            app.MapFallbackToFile("index.html");

            app.Run();
        }

       
    }
}