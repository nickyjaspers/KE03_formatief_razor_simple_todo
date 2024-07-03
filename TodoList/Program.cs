using Microsoft.EntityFrameworkCore;
using TodoList.DAL;

namespace TodoList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            // Add the database context (in-memory database) to the container.
            // We gebruiken de in-memory database alleen even voor te testen.
            // In een productieomgeving zou je een echte database moeten gebruiken.
            // Als je de applicatie afsluit is de data weg.
            builder.Services.AddDbContext<TodoDbContext>(options =>
                options.UseInMemoryDatabase("TodoDatabase"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
