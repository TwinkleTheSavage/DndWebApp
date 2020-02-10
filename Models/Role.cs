using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DndWebApp.Models
{
    public enum Roles { 
        DM,
        Player
    }
    public class Role
    {
        public Roles role { get; set; }
        public string Description { get; set; }
        public List<User> Users { get; set; }
    }
}