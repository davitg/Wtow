using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
using Wtow.Data;
using Wtow.Domain;

namespace Wtow.Data
{
    public class TitleSeeder
    {
        private readonly TitleContext _ctx;
        private readonly IHostingEnvironment _hosting;
        private readonly UserManager<AppUser> _userManager;

        public TitleSeeder(TitleContext ctx, IHostingEnvironment hosting, UserManager<AppUser> userManager)
        {
            _ctx = ctx;
            _hosting = hosting;
            _userManager = userManager;
        }

        public async Task Seed()
        {
            _ctx.Database.EnsureCreated();

            var user = await _userManager.FindByEmailAsync("davit@gri.consulting");

            if (user == null)
            {
                user = new AppUser()
                {
                    FirstName = "Davit",
                    LastName = "Grigoryan",
                    UserName = "davit@gri.consulting",
                    Email = "davit@gri.consulting"
                };

                var result = await _userManager.CreateAsync(user, "P@ssw0rd!");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Failed to create default user");
                }
            }
        }
    }
}
