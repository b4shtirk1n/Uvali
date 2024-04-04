using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Uvali.API.Models;

[Table("gender")]
public partial class Gender
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(10)]
    public string? Name { get; set; }

    [InverseProperty("GenderNavigation")]
    public virtual ICollection<Participant> Participants { get; set; } = new List<Participant>();
}
