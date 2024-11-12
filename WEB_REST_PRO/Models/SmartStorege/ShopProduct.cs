using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WEB_REST_PRO.Models.SmartStorege;

public class ShopProduct : Core
{
  

    public Guid ProductId { get; set; }

    public Guid ShopId { get; set; }
    public Guid UserId { get; set; }

    public int TotalAmount { get; set; }

    public double SalePrice { get; set; }

}
