using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//DBContext page
namespace TempleToursProject.Models
{
    //TourDbContext inherits from the DbContext
    public class TourDbContext : DbContext
    {
        public TourDbContext (DbContextOptions<TourDbContext> options) : base (options)
        {

        }

        //This determines what tables are created in the database
        public DbSet<GroupInfo> GroupInfo { get; set; }
        public DbSet<TimeSlots> TimeSlots { get; set; }
    }
}
