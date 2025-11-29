using Microsoft.AspNetCore.Identity;
using OnlineVotingApplication.Areas.Identity.Data;
using OnlineVotingApplication.Data;

namespace OnlineVotingApplication.Models
{
    public class DbInitializer
    {
        public static async Task InitializeAsync(OnlineVotingApplicationContext context, IServiceProvider serviceProvider, UserManager<OnlineVotingApplicationUser> userManager)


        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = { "Admin", "User", "Candidate", "Voter" };

            IdentityResult roleResult;
            foreach (var RoleName in roleNames)
            {
                var roleExists = await RoleManager.RoleExistsAsync(RoleName);
                if (!roleExists)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(RoleName));
                }
            }
            string Email = "admin@outlook.com";
            string Password = "Admin,./123";
            if (userManager.FindByEmailAsync(Email).Result == null)
            {
                OnlineVotingApplicationUser user = new OnlineVotingApplicationUser();
                user.UserName = Email;
                user.Email = Email;
                IdentityResult result = userManager.CreateAsync(user, Password).Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user,
                                        "Admin").Wait();
                }
            }
        }
    }
}
