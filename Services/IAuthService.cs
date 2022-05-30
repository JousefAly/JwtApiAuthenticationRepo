using JwtApiAuthentication.Models;
using System.Threading.Tasks;

namespace JwtApiAuthentication.Services
{
    public interface IAuthService
    {
        Task<AuthModel> Register(RegisterModel model);
    }
}
