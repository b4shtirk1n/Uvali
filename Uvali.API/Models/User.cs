using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Uvali.API.Models;

[Table("User")]
[Index("Email", "Password", Name = "user_email_password_index")]
[Index("Email", Name = "user_uk", IsUnique = true)]
public partial class User
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("email")]
    [StringLength(40)]
    public string Email { get; set; } = null!;

    [Column("password")]
    [StringLength(64)]
    public string Password { get; set; } = null!;

    [Column("role")]
    public int Role { get; set; }

    [ForeignKey("Role")]
    [InverseProperty("Users")]
    public virtual Role RoleNavigation { get; set; } = null!;

    [InverseProperty("UserNavigation")]
    public virtual ICollection<Userqa> Userqas { get; set; } = new List<Userqa>();
}
