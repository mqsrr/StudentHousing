using StudentHousing.Domain.Models;

namespace StudentHousing.Application.Services;

public interface IAuthenticationService
{
    Task<IdentityResponse?> LoginAsync(string username, string password);

    Task<IdentityResponse?> RegisterAsync(Identity identity);
    
    Task<bool> IsEmailExists(string email);
}