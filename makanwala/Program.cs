using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using makanwala.Areas.Identity.Data;


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("UserDBContextConnection") ?? throw new InvalidOperationException("Connection string 'UserDBContextConnection' not found.");

builder.Services.AddDbContext<UserDBContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<makanwalaUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<UserDBContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthentication();  //  Ensure authentication is used before authorization
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "admin",
    pattern: "admin/{action=Dashboard}/{id?}",
    defaults: new { controller = "Admin" });


app.MapRazorPages();
app.Run();
