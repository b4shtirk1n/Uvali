using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Uvali.API.Models;

[Table("userqa")]
public partial class Userqa
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    public int User { get; set; }

    [Column("question")]
    public int Question { get; set; }

    [Column("answer")]
    public int Answer { get; set; }

    [ForeignKey("Answer")]
    [InverseProperty("Userqas")]
    public virtual Answer AnswerNavigation { get; set; } = null!;

    [ForeignKey("Question")]
    [InverseProperty("Userqas")]
    public virtual Question QuestionNavigation { get; set; } = null!;

    [ForeignKey("User")]
    [InverseProperty("Userqas")]
    public virtual User UserNavigation { get; set; } = null!;
}
