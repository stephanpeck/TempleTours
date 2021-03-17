using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleToursProject.Models
{
    public class GroupInfo
    {
        [Key]
        public int GroupInfoId { get; set; }

        [Required]
        public string GroupName { get; set; }

        [Required]
        public int GroupSize { get; set; }

        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }

    }
}
