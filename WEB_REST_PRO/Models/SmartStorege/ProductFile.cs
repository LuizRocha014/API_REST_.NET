using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WEB_REST_PRO.Models.SmartStorege;

public class ProductFile : Core
{

    [ForeignKey("Product")]
    public Guid ProductId { get; set; }

    [ForeignKey("File")]
    public Guid FileId { get; set; }

    public string Description { get; set; }

    public virtual Product Product { get; set; }

    public virtual File File { get; set; }
}
