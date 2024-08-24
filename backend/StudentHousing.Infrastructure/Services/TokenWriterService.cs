using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using StudentHousing.Application.Services;
using StudentHousing.Domain.Models;
using StudentHousing.Infrastructure.Settings;

namespace StudentHousing.Infrastructure.Services;

internal sealed class TokenWriter(IOptions<JwtSettings> settings) : ITokenWriter
{
    private readonly JwtSettings _jwtSettings = settings.Value;

    public string GenerateToken(Identity identity)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, identity.Username),
            new Claim(JwtRegisteredClaimNames.Email, identity.Email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim("Id", identity.Id.ToString()),
            new Claim("Birthdate", identity.Birthdate.ToString("yyyy-MM-dd")),
            new Claim(ClaimTypes.Role, identity.Role.ToString())
        };

        var token = new JwtSecurityToken(
            issuer: _jwtSettings.Issuer,
            audience: _jwtSettings.Audience,
            claims: claims,
            expires: DateTime.Now.AddHours(1),
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}