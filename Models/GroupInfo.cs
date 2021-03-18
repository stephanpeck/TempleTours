using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleToursProject.Models
{
    //Class for the group info
    public class GroupInfo
    {
        //Primary key for the Group Info 
        [Key]
        public int GroupInfoId { get; set; }

        [Required]
        public string GroupName { get; set; }

        //Only allows group of size 1-50 so that the tour guides don't get overwhelmed
        [Required]
        [Range(1,50)]
        public int GroupSize { get; set; }

        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string SelectedAppointmentDay { get; set; }

        public string SelectedAppointmentTime { get; set; }

    }
}
