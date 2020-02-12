using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DndWebApp.Models
{
    public class Campaign
    {
        [Key]
        public int CampaginId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [ForeignKey("DungeonMasterId")]
        public User DungeonMaster { get; set; }
        [Required]
        public int DungeonMasterId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Date Updated")]
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}