﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Uvali.API.Models;

[Table("role")]
public partial class Role
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(15)]
    public string Name { get; set; } = null!;

    [InverseProperty("RoleNavigation")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
