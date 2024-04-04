using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Uvali.API.Models;

[Table("question")]
public partial class Question
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    [InverseProperty("QuestionNavigation")]
    public virtual ICollection<Questionanswer> Questionanswers { get; set; } = new List<Questionanswer>();

    [InverseProperty("QuestionNavigation")]
    public virtual ICollection<Userqa> Userqas { get; set; } = new List<Userqa>();
}
