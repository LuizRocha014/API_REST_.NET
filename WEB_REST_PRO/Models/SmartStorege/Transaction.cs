using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using WEB_REST_PRO.Models.SmartStorege;

public class Transaction : Core
{

    public int Type { get; set; } // Assuming this is an enum

    [ForeignKey("Supplier")]
    public Guid SupplierId { get; set; }

    [ForeignKey("Customer")]
    public Guid CustomerId { get; set; }

    [ForeignKey("Product")]
    public Guid ProductId { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }

    public double TotalValue { get; set; }

    public string PaymentMethod { get; set; }

    public string Notes { get; set; }

    [ForeignKey("Company")]
    public Guid CompanyId { get; set; }

    [ForeignKey("Shop")]
    public Guid ShopId { get; set; }

    [ForeignKey("User")]
    public Guid UserId { get; set; }

    public virtual Supplier Supplier { get; set; }

    public virtual Customer Customer { get; set; }

    public virtual Product Product { get; set; }

    public virtual Company Company { get; set; }

    public virtual Shop Shop { get; set; }

    public virtual User User { get; set; }
}
