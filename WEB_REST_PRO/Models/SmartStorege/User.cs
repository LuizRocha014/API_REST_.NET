using System;
using System.Data;

namespace WEB_REST_PRO.Models.SmartStorege
{
    public class User : Core
    {
        public Guid RoleId { get; set; } 

        public string Name { get; set; }
        public string UserName { get; set; } 

        public string Email { get; set; } 

        public DateTime? EmailVerifiedAt { get; set; }

        public string Password { get; set; }

        public string RememberToken { get; set; } 
    }
}

