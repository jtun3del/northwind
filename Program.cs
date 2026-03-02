using Microsoft.EntityFrameworkCore;





// Connection info stored in appsettings.json


IConfiguration configuration = new ConfigurationBuilder()


    .AddJsonFile("appsettings.json")


    .Build();

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(
    configuration["Data:NorthWind:ConnectionString"]));
var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Product}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Category}/{id?}");

app.Run();
