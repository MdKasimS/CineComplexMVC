using CineComplexAdminMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

// This sets Ketrel as default edge server(aks Application server) which
// hosts our ASP.NET Core Web Application.
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MovieDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'MovieDbContext' not found.")));

// Add services to the container.
/*
 * In an ASP.NET Core MVC application, the line builder.Services.AddControllersWithViews(); 
 * is used to register the MVC services with the Dependency Injection (DI) container. 
 * Here�s what it does in detail:
 *  1. Register MVC Services:
 *      AddControllersWithViews() registers the services required for MVC controllers and views. 
 *      This includes services for model binding, action filters, validation, and more.
 *  2. Enable MVC Framework:
        It sets up the MVC framework so that you can use controllers and views in your application. 
        This is essential for handling HTTP requests and rendering views.
   
 * When you add this line in the Program.cs file, it ensures that your application can recognize and use controllers and views
 * and can be used to handle requests and render responses.

 */
builder.Services.AddControllersWithViews();

// Register your DbContext with the connection string
builder.Services.AddDbContext<CineComplexAdminMVC.Models.MovieDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
