using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Uvali.API.Models;

[Table("participant")]
[Index("Gender", Name = "participant_gender_index")]
public partial class Participant
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("firstname")]
    [StringLength(30)]
    public string Firstname { get; set; } = null!;

    [Column("lastname")]
    [StringLength(30)]
    public string Lastname { get; set; } = null!;

    [Column("secondname")]
    [StringLength(30)]
    public string? Secondname { get; set; }

    [Column("gender")]
    public int? Gender { get; set; }

    [ForeignKey("Gender")]
    [InverseProperty("Participants")]
    public virtual Gender? GenderNavigation { get; set; }
}
