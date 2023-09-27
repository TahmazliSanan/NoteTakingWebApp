using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NoteTakingWebApp.DataAccess.Db;
using NoteTakingWebApp.Service.Services.Abstracts;
using NoteTakingWebApp.Service.Services.Config;
using NoteTakingWebApp.Service.Services.Implementations;

namespace NoteTakingWebApp.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionStringForDb = builder.Configuration.GetConnectionString("ConnectionStringForDb");
            var mapperConfig = new MapperConfiguration((mc) =>
            {
                mc.AddProfile(new MapperProfile());
            });

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>((options) =>
            {
                options.UseNpgsql(connectionStringForDb);
            });
            builder.Services.AddSingleton(mapperConfig.CreateMapper());
            builder.Services.AddScoped<INoteService, NoteService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Home}/{id?}");
            app.Run();
        }
    }
}