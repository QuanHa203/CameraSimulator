using System;
using System.Collections.Generic;

namespace CameraServer.Models;

public partial class Video
{
    public int Id { get; set; }

    public string Url { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
