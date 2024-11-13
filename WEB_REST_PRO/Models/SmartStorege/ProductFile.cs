using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WEB_REST_PRO.Models.SmartStorege;

public class ProductFile : Core
{

    public Guid ProductId { get; set; }

    public Guid FileId { get; set; }

    public string Description { get; set; }
}
