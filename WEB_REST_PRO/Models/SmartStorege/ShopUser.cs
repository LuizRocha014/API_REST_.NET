using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WEB_REST_PRO.Models.SmartStorege;

public class ShopUser : Core
{
    [Key]
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid ShopId { get; set; }

    public bool UserMainShop { get; set; }
}
