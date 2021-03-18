using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//ITourRepository creates a queryable Book Model
namespace TempleToursProject.Models
{
    //ITourRepository created that will be inherited by EFTourRepository
    public interface ITourRepository
    {
        IQueryable<GroupInfo> Groups { get; }

        IQueryable<TimeSlots> TimeSlots { get; }
    }
}
