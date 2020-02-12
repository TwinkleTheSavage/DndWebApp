using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DndWebApp.Models
{
    public enum Roles { 
        DM,
        Player
    }
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public Roles role { get; set; }
        public string Description { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateCreated { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<User> Users { get; set; }

    }
}