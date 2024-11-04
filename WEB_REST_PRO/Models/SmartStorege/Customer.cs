using System;
using System.ComponentModel.DataAnnotations;
using WEB_REST_PRO.Models.SmartStorege;

public class Customer : Core
{

    public string Nome { get; set; }
    public string Cnpj { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string AddressNumber { get; set; }
    public string? Neighborhood { get; set; }
    public string? ZipCode { get; set; }
    public string? Phone { get; set; }
    public string? Reference { get; set; }
}

