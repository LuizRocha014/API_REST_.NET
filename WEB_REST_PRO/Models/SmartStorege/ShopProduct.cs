using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WEB_REST_PRO.Models.SmartStorege;

public class ShopProduct : Core
{
  

    [ForeignKey("Product")]
    public Guid ProductId { get; set; }

    [ForeignKey("Shop")]
    public Guid ShopId { get; set; }

    public int TotalAmount { get; set; }

    public double SalePrice { get; set; }

    public virtual Product Product { get; set; }

    public virtual Shop Shop { get; set; }

}
