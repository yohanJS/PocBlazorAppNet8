using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PocBlazorAppNet8.Models;

namespace PocBlazorAppNet8.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ICollection<UserPrimaryInfo>? userPrimaryInfo { get; set; }
    }
}
