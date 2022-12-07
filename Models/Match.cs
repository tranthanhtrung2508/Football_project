using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Football_project.Models
{
    public class Match
    {
        [Key]
        public long MatchID { get; set; }
        public string Team1Name { get; set; }
        public string Team2Name { get; set; }
        public string TiSo { get; set; }
    }
}