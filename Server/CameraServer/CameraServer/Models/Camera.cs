using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CameraServer.Models;

[Table("Camera")]
public partial class Camera
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string CameraName { get; set; } = null!;

    [StringLength(100)]
    public string Password { get; set; } = null!;

    [StringLength(10)]
    public string ConnectionCode { get; set; } = null!;
}
