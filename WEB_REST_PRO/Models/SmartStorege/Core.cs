using System;
using System.ComponentModel.DataAnnotations;

namespace WEB_REST_PRO.Models.SmartStorege
{
    public class Core
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool Active { get; set; }
    }
}

