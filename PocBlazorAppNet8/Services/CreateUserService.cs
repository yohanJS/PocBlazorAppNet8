using PocBlazorAppNet8.Data;
using PocBlazorAppNet8.Models;

namespace PocBlazorAppNet8.Services
{
    public class CreateUserService : ICreateUserService
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateUserService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateUserAsync(UserPrimaryInfo newUser)
        {
            // Add the new user to the database
            _dbContext.UserPrimaryInfo.Add(newUser);
            await _dbContext.SaveChangesAsync();
        }
    }
}
