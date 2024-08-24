﻿namespace StudentHousing.Contracts.Auth.Requests;

public sealed class LoginRequest
{
    public required string Username { get; init; }

    public required string Password { get; init; }
}