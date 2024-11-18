using System;
using System.Collections.Generic;

namespace CameraServer.Models;

public partial class User
{
    public int Id { get; set; }

    public int IdRole { get; set; }

    public int? IdVideo { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool? IsBan { get; set; }

    public virtual Role IdRoleNavigation { get; set; } = null!;

    public virtual Video? IdVideoNavigation { get; set; }

    public virtual ICollection<Camera> IdCameras { get; set; } = new List<Camera>();
}
