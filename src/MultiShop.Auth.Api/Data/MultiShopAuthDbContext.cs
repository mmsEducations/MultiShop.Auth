using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MultiShop.Auth.Api.Data.Entites;

namespace MultiShop.Auth.Api.Data
{
    public class MultiShopAuthDbContext : IdentityDbContext<ApplicationUser>
    {
        public MultiShopAuthDbContext(DbContextOptions<MultiShopAuthDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("auth");
        }
    }
}
