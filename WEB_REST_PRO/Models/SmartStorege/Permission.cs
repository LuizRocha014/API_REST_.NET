﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WEB_REST_PRO.Models.SmartStorege;

public class Permission : Core
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; }

}
