using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web4
{
    public static class SeedData
    {
        public static async Task EnsureSeedData(IServiceProvider provider)
        {
            var roleManager = provider.GetRequiredService<RoleManager<IdentityRole>>();

            foreach (var roleName in RoleNames.AllRoles)
            {
                var role = roleManager.FindByNameAsync(roleName).Result;
                if (role == null)
                {
                    var result = roleManager.CreateAsync(new IdentityRole { Name = roleName }).Result;
                    if (!result.Succeeded) throw new Exception(result.Errors.First().Description);
                }
            }

            var userManager = provider.GetRequiredService<UserManager<IdentityUser>>();
            var adminResult = await userManager.CreateAsync(DefaultUsers.Administrator, "Username!1");
            var moderResult = await userManager.CreateAsync(DefaultUsers.Moderator, "Username!1");
            var userResult = await userManager.CreateAsync(DefaultUsers.User, "Username!1");

            if (adminResult.Succeeded || userResult.Succeeded || moderResult.Succeeded)
            {
                var adminUser = await userManager.FindByEmailAsync(DefaultUsers.Administrator.Email);
                var moderatorUser = await userManager.FindByEmailAsync(DefaultUsers.Moderator.Email);
                var commonUser = await userManager.FindByEmailAsync(DefaultUsers.User.Email);

                await userManager.AddToRoleAsync(adminUser, RoleNames.Administrator);
                await userManager.AddToRoleAsync(moderatorUser, RoleNames.Moderator);
                await userManager.AddToRoleAsync(commonUser, RoleNames.User);
            }
        }

        public static class RoleNames
        {
            public const string Administrator = "Administrator";
            public const string Moderator = "Moderator";
            public const string User = "User";

            public static IEnumerable<string> AllRoles
            {
                get
                {
                    yield return Administrator;
                    yield return User;
                    yield return Moderator;
                }
            }
        }

        public static class DefaultUsers
        {
            public static readonly IdentityUser Administrator = new IdentityUser
            {
                Email = "admin@lingva.com",
                EmailConfirmed = true,
                UserName = "admin@lingva.com"
            };
            
            public static readonly IdentityUser Moderator = new IdentityUser
            {
                Email = "moderator@lingva.com",
                EmailConfirmed = true,
                UserName = "moderator@lingva.com"
            };

            public static readonly IdentityUser User= new IdentityUser
            {
                Email = "user@lingva.com",
                EmailConfirmed = true,
                UserName = "user@lingva.com"
            };

            public static IEnumerable<IdentityUser> AllUsers
            {
                get
                {
                    yield return Administrator;
                    yield return Moderator;
                    yield return User;
                }
            }
        }
    }
}
