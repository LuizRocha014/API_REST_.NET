using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Category
{
    [Key]
    public Guid Id { get; set; }

    public string Description { get; set; }
}