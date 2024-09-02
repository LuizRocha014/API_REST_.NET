using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using WEB_REST_PRO.Models.SmartStorege;

public class Transaction : Core
{

    public tipoTransacao Type { get; set; } // Assuming this is an enum

    [ForeignKey("Supplier")]
    public Guid? SupplierId { get; set; }

    [ForeignKey("Customer")]
    public Guid? CustomerId { get; set; }

    [ForeignKey("Product")]
    public Guid ProductId { get; set; }

    public Guid TargetCompany { get; set; }

    public Guid OriginCompany { get; set; }

    [ForeignKey("User")]
    public Guid UserId { get; set; }

    public string? PaymentMethod { get; set; }

    public string? Notes { get; set; }

    public virtual Supplier Supplier { get; set; }

    public virtual Product Product { get; set; }

    public virtual User User { get; set; }

    public enum tipoTransacao
    {
        sale, buy,
    }
}
