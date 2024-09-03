using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WEB_REST_PRO.Models;
using WEB_REST_PRO.Models.Common;

public class Product : Core
{

    [ForeignKey("Category")]
    public Guid CategoryId { get; set; }

    public string Sku { get; set; }

    public string Brand { get; set; }

    [ForeignKey("Supplier")]
    public Guid SupplierId { get; set; }

    public double PurchasePrice { get; set; }

    public int MinimumAmount { get; set; }

    public int? Quantity { get; set; }

    public double? Price { get; set; }

    public double? TotalValue { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string Description { get; set; }

    public string AdditionalInfo { get; set; }

    public virtual Category Category { get; set; }

    public virtual Supplier Supplier { get; set; }
}
