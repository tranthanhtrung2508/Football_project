using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Football_project.Models
{
    public class Team
    {
        [Key]
        public long TeamID { get; set; }
        public string TeamName { get; set; }
        public int Amount { get; set; }
    }
}