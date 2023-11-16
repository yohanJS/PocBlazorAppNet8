using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PocBlazorAppNet8.Models;

namespace PocBlazorAppNet8.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        //My Custom tables
        public DbSet<UserPrimaryInfo>? UserPrimaryInfo { get; set; }
    }
}
