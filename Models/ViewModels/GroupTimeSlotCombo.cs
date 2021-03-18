using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleToursProject.Models.ViewModels
{
    //ViewModel to allow the access of both the GroupInfo model and the TimeSlots model
    public class GroupTimeSlotCombo
    {
        public GroupInfo GroupInfo { get; set; }

        //TimeSlots is set to an IEnumerable so that we can iterate through the data
        public IEnumerable<TimeSlots> TimeSlots { get; set; }
    }
}
