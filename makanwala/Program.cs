using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using makanwala.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Add after AddControllersWithViews()
//builder.Services.AddAuthorization(options =>
//{
//    options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
//});

//Configure Identity
//builder.Services.AddDefaultIdentity<IdentityUser>(options => {
//    options.SignIn.RequireConfirmedAccount = false;
//})
//.AddRoles<IdentityRole>() // Enable roles
//.AddEntityFrameworkStores<ApplicationDbContext>();


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
app.MapControllerRoute(
    name: "admin",
    pattern: "admin/{action=Dashboard}/{id?}",
    defaults: new { controller = "Admin" });



app.Run();
