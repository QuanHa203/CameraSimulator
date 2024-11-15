using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CameraServer.Models;

[Table("User")]
public partial class User
{
    [Key]
    public int Id { get; set; }

    public int IdRole { get; set; }

    public int? IdVideo { get; set; }

    [StringLength(100)]
    public string UserName { get; set; } = null!;

    [StringLength(100)]
    public string Password { get; set; } = null!;

    [StringLength(100)]
    public string Email { get; set; } = null!;

    public bool? IsBan { get; set; }

    [ForeignKey("IdRole")]
    [InverseProperty("Users")]
    public virtual Role IdRoleNavigation { get; set; } = null!;

    [ForeignKey("IdVideo")]
    [InverseProperty("Users")]
    public virtual Video IdVideoNavigation { get; set; } = null!;
}