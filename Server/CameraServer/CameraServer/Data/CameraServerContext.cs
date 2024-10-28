using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CameraServer.Models;

namespace CameraServer.Data
{
    public class CameraServerContext : DbContext
    {
        public CameraServerContext (DbContextOptions<CameraServerContext> options)
            : base(options)
        {
        }

        public DbSet<CameraServer.Models.User> User { get; set; } = default!;
        /*public DbSet<CameraServer.Models.Camera> camera { get; set; } = default!;*/
    }
}
