using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security;
using WEB_REST_PRO.Models.Common;

public class RolePermission : Core
{ 
    [ForeignKey("Permission")]
    public Guid PermissionId { get; set; }

    [ForeignKey("Role")]
    public Guid RoleId { get; set; }
    public bool Active { get; set; }

    public virtual Permission Permission { get; set; }

    public virtual Role Role { get; set; }
}
