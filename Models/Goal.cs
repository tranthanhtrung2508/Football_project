using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Football_project.Models
{
    public class Goal
    {
        [Key]
        public long GoalID { get; set; }
        public long MatchID { get; set; }
        public string PlayerName { get; set; }
        public long NumberOfGoal { get; set; }

    }
}