﻿using Microsoft.AspNetCore.Identity;

namespace AdminTemplate.Models.Identity
{
    public class ApplicationRole : IdentityRole
    {
        public string? Description { get; set; }
     
        public ApplicationRole()
        {

        }
        public  ApplicationRole(string roleName, string description): base(roleName)
        {
            this.Description = description;
        }
    }
}
