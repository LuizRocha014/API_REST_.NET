using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WEB_REST_PRO.Models.SmartStorege
{
	public class Product : Core
	{
        public string? Sku { get; set; }
        public string? StorageLocation { get; set; }
        public string? Description { get; set; }
        public string? AdditionalInfo { get; set; }
        public string? CodProd { get; set; }
        public string? Brand { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int MinimumAmount { get; set; }
        public int TotalAmount { get; set; }
        public double SalePrice { get; set; }
        public double PurchasePrice { get; set; }
        public Guid? SupplierId { get; set; }
        public Guid CategoriaId { get; set; }

    }
}

