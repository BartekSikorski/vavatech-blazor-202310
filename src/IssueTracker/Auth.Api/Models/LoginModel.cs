﻿namespace Auth.Api.Models;

public record LoginModel
{
    public string Username { get; set; }
    public string Password { get; set; }
}
