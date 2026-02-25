using Dating.Api.Entities;

namespace Dating.Api.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
        string GenerateRefreshToken();
    }
}
