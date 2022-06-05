using JwtApiAuthentication.Models;
using System.Threading.Tasks;

namespace JwtApiAuthentication.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
    }
}
