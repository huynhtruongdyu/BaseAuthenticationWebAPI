using BaseAuthenticationWebAPI.Core.Domain;

namespace BaseAuthenticationWebAPI.Core.Applications.Interfaces.Services
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
