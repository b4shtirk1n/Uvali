using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Uvali.API.Models;

[Table("questionanswer")]
public partial class Questionanswer
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("question")]
    public int Question { get; set; }

    [Column("answer")]
    public int Answer { get; set; }

    [ForeignKey("Answer")]
    [InverseProperty("Questionanswers")]
    public virtual Answer AnswerNavigation { get; set; } = null!;

    [ForeignKey("Question")]
    [InverseProperty("Questionanswers")]
    public virtual Question QuestionNavigation { get; set; } = null!;
}
