using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Uvali.API.Models;

[Table("answer")]
public partial class Answer
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    [InverseProperty("AnswerNavigation")]
    public virtual ICollection<Questionanswer> Questionanswers { get; set; } = new List<Questionanswer>();

    [InverseProperty("AnswerNavigation")]
    public virtual ICollection<Userqa> Userqas { get; set; } = new List<Userqa>();
}
