using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CameraServer.Models;

[Keyless]
[Table("CameraUser")]
public partial class CameraUser
{
    public int IdCamera { get; set; }

    public int IdUser { get; set; }

    [ForeignKey("IdCamera")]
    public virtual Camera IdCameraNavigation { get; set; } = null!;

    [ForeignKey("IdUser")]
    public virtual User IdUserNavigation { get; set; } = null!;
}
