using System;
using System.Collections.Generic;

namespace CameraServer.Models;

public partial class Camera
{
    public int Id { get; set; }

    public string CameraName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string ConnectionCode { get; set; } = null!;

    public virtual ICollection<User> IdUsers { get; set; } = new List<User>();
}
