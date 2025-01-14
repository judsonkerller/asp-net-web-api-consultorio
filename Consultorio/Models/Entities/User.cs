﻿using Microsoft.AspNetCore.Identity;

namespace Consultorio.Models.Entities
{
    public class User : Base
    {
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}