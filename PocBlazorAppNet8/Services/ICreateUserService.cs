using PocBlazorAppNet8.Data;
using PocBlazorAppNet8.Models;

namespace PocBlazorAppNet8.Services
{
    public interface ICreateUserService
    {
        Task CreateUserAsync(UserPrimaryInfo newUser);
    }
}
