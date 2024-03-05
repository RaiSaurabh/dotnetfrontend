using Microsoft.EntityFrameworkCore;
using ASP_NET_Core_App.Models;
namespace ASP_NET_Core_App.Data
{
    using ASP_NET_Core_App.Controllers;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    //using ASP_NET_Core_App.Controllers;

    public class AppDbContext : DbContext
    {
        // public DbSet<StaffController> Staff { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        //using ASP_NET_Core_App.Controllers;
        public DbSet<ASP_NET_Core_App.Models.Staff> Staff { get; set; } = default!;
    }
}
