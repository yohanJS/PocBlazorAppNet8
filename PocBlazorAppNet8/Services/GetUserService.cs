using Microsoft.EntityFrameworkCore;
using PocBlazorAppNet8.Client;
using PocBlazorAppNet8.Data;
using PocBlazorAppNet8.Models;

namespace PocBlazorAppNet8.Services
{
    public class GetUserService : IGetUserService
    {
        private readonly ApplicationDbContext? _dbContext;

        public GetUserService(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public async Task<List<UserPrimaryInfo>> GetPrimaryInfoAsync()
        {

            var users = await _dbContext.UserPrimaryInfo.ToListAsync();

            return users;

        }
    }
}
