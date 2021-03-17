using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//DBContext page
namespace TempleToursProject.Models
{
    public class TourDbContext : DbContext
    {
        public TourDbContext (DbContextOptions<TourDbContext> options) : base (options)
        {

        }

        public DbSet<GroupInfo> GroupInfo { get; set; }
    }
}
