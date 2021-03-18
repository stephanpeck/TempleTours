using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleToursProject.Models
{
    //Class for the TimeSlots
    public class TimeSlots
    {
        //Key required for there to be two tables in the database
        [Key]
        public int TimeSlotsId { get; set; }

        public DateTime TimeSlot { get; set; }

        //Scheduled boolean set to false. once it is changed to true then that time won't be visible.
        public bool Scheduled { get; set; } = false;


    }
}
