using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Football_project.Models
{
    public class Role
    {
        [Key]
        public long RoleID { get; set; }
        public string RoleName { get; set; }
    }
}