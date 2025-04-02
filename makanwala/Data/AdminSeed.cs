namespace makanwala.Data
{
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;

    
        public static class AdminSeed
        {
            public static async Task SeedAdminAsync(UserManager<IdentityUser> userManager,
                                                  RoleManager<IdentityRole> roleManager)
            {
                // एडमिन रोल चेक करें
                if (!await roleManager.RoleExistsAsync("Admin"))
                {
                    await roleManager.CreateAsync(new IdentityRole("Admin"));
                }

                // एडमिन यूजर चेक करें
                var adminEmail = "admin@realestate.com";
                var adminUser = await userManager.FindByEmailAsync(adminEmail);

                if (adminUser == null)
                {
                    var newAdmin = new IdentityUser
                    {
                        UserName = adminEmail,
                        Email = adminEmail,
                        EmailConfirmed = true
                    };

                    var result = await userManager.CreateAsync(newAdmin, "Admin@123");

                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(newAdmin, "Admin");
                    }
                }
            }
        }
    }