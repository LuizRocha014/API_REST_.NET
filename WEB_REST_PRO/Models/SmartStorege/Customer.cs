using System;
using System.ComponentModel.DataAnnotations;
using WEB_REST_PRO.Models.Common;

public class Customer : Core
{

    public string Name { get; set; }

    public string Cpf { get; set; }

    public string Phone { get; set; }

    public string ZipCode{ get; set;}
}
