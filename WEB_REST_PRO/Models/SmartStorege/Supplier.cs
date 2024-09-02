using System.ComponentModel.DataAnnotations;
using WEB_REST_PRO.Models.Common;

public class Supplier : Core
{
    public string Name { get; set; }

    public string Cnpj { get; set; }

    public string Phone { get; set; }

    public string ZipCode { get; set; }

    public string Address { get; set; } 

    public string AddressNumber { get; set; }

    public string Email { get; set; }

    public string Responsible { get; set; }

    public string ResponsiblePhone { get; set; }

    public string Segment { get; set; }

    public string File { get; set; }
}