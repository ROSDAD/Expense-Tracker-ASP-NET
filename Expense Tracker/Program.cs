using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DI
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseMySql(builder.Configuration.GetConnectionString("DevConnection"), new MySqlServerVersion(new Version(6, 0, 29))));
var app = builder.Build();



//Register Syncfusion License   
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NCaF5cXmZCdkxzWmFZfVpgfF9CZFZRTGY/P1ZhSXxXdkJjX31edHBVT2ZYU0I=");


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
