using PocBlazorAppNet8.Data;
using PocBlazorAppNet8.Models;

namespace PocBlazorAppNet8.Services
{
    public interface IGetUserService
    {
        Task<List<UserPrimaryInfo>> GetPrimaryInfoAsync();
    }
}
