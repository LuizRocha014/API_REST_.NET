using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WEB_REST_PRO.Models.SmartStorege;

public class Shop : Core
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; }

    [ForeignKey("Company")]
    public Guid CompanyId { get; set; }

    public string Location { get; set; }

    public virtual Company? Company { get; set; }
}
