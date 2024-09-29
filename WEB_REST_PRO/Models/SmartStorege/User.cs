using System;
using System.Data;

namespace WEB_REST_PRO.Models.SmartStorege
{
    public class User : Core
    {
        public Guid RoleId { get; set; } // Foreign key referencing Roles.Id

        public string Name { get; set; } // nvarchar(max)
        public string UserName { get; set; } // nvarchar(max)

        public string Email { get; set; } // nvarchar

        public DateTime? EmailVerifiedAt { get; set; } // datetime, nullable

        public string Password { get; set; } // nvarchar(max)

        public string RememberToken { get; set; } // nvarchar(max)
        public virtual Role Role { get; set; }
    }
}

