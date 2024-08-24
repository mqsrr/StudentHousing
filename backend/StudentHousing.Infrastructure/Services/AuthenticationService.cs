using Microsoft.AspNetCore.Identity;
using StudentHousing.Application.Persistence;
using StudentHousing.Application.Services;
using StudentHousing.Domain.Models;
using StudentHousing.Infrastructure.Helpers;

namespace StudentHousing.Infrastructure.Services;

internal sealed class AuthenticationService(ISqlDataAccess dataAccess, ITokenWriter tokenWriter) : IAuthenticationService
{
    private readonly ISqlDataAccess _dataAccess = dataAccess;
    private readonly ITokenWriter _tokenWriter = tokenWriter;

    public async Task<IdentityResponse?> LoginAsync(string username, string password)
    {
        var result = await _dataAccess.ExecuteQueryAsync<Identity, dynamic>(StoredProcedures.Auth.Login,
            new {Username = username});
        
        var createdIdentity = result.FirstOrDefault();
        if (createdIdentity is null)
        {
            return null;
        }

        var passwordHasher = new PasswordHasher<Identity>();
        if (passwordHasher.VerifyHashedPassword(createdIdentity, createdIdentity.Password, password) is PasswordVerificationResult.Failed)
        {
            return null;
        }
        
        string jwtToken = _tokenWriter.GenerateToken(createdIdentity);
        return new IdentityResponse
        {
            Role = createdIdentity.Role,
            Token = jwtToken,
        };
    }

    public async Task<IdentityResponse?> RegisterAsync(Identity identity)
    {
        bool isCreated = await _dataAccess.ExecuteScalarAsync(StoredProcedures.Auth.Register, identity);
        if (!isCreated)
        {
            return null;
        }
        
        string jwtToken = _tokenWriter.GenerateToken(identity);
        return new IdentityResponse
        {
            Role = identity.Role,
            Token = jwtToken
        };
    }

    public async Task<bool> IsEmailExists(string email)
    {
        var result = await _dataAccess.ExecuteQueryAsync<Identity, dynamic>(StoredProcedures.Auth.IsEmailExists,
            new {Email = email});

        return result.FirstOrDefault() is not null;
    }
}