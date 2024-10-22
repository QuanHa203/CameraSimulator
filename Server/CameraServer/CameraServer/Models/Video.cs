using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CameraServer.Models;

[Table("Video")]
public partial class Video
{
    [Key]
    public int Id { get; set; }

    [StringLength(500)]
    public string Url { get; set; } = null!;

    [InverseProperty("IdVideoNavigation")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
