﻿using Microsoft.AspNetCore.Identity;

namespace IdentityRole.DAL
{
    public class AppUser:IdentityUser<int>
    {
        public string NameSurname { get; set; }
    }
}
