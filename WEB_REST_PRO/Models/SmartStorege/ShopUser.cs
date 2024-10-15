using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WEB_REST_PRO.Models.SmartStorege;

public class ShopUser : Core
{
    [Key]
    public Guid Id { get; set; }

    [ForeignKey("User")]
    public Guid UserId { get; set; }

    [ForeignKey("Shop")]
    public Guid ShopId { get; set; }

    public bool UserMainShop { get; set; }

    public virtual User User { get; set; }

    public virtual Shop Shop { get; set; }
}
