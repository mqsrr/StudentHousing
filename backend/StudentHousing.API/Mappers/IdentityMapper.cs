using Microsoft.AspNetCore.Identity;
using StudentHousing.Contracts.Auth.Requests;
using StudentHousing.Domain.Models;

namespace StudentHousing.API.Mappers;

internal static class IdentityMapper
{
    internal static Identity ToIdentity(this RegisterRequest request)
    {
        var identity = new Identity
        {
            Id = request.Id,
            Username = request.Username,
            Email = request.Email,
            Birthdate = request.Birthdate,
            Password = request.Password,
            Role = request.Role
        };

        var passwordHasher = new PasswordHasher<Identity>();
        identity.Password = passwordHasher.HashPassword(identity, identity.Password);

        return identity;
    }

    internal static Identity ToIdentity(this RegisterAdminRequest request)
    {
        var identity = new Identity
        {
            Id = request.Id,
            Username = request.Username,
            Email = request.Email,
            Birthdate = request.Birthdate,
            Password = request.Password,
            Role = request.Role
        };

        var passwordHasher = new PasswordHasher<Identity>();
        identity.Password = passwordHasher.HashPassword(identity, identity.Password);

        return identity;
    }

    internal static Student ToStudent(this RegisterRequest request)
    {
        return new Student
        {
            Id = request.Id,
            Username = request.Username,
            FullName = request.FullName,
            Email = request.Email,
            Birthdate = request.Birthdate,
            Room = request.Room
        };
    }
}