using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WEB_REST_PRO.Models.SmartStorege;

public class UserPermission : Core
{

    [ForeignKey("User")]
    public Guid UsuarioId { get; set; }

    [ForeignKey("Permission")]
    public Guid AcessoId { get; set; }

    public virtual User User { get; set; }

    public virtual Permission Permission { get; set; }
}
