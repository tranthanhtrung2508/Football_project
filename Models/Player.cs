using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Football_project.Models
{
    public class Player
    {
        [Key]
        public long PlayerID { get; set; }
        public string PlayerName { get; set; }
        public Nullable<int> PlayerNumber { get; set; }
        public string RoleName { get; set; }
        public string TeamName { get; set; }
    }
}