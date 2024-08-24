using StudentHousing.Domain.Models;

namespace StudentHousing.Application.Services;

public interface ITokenWriter
{
    string GenerateToken(Identity identity);
}