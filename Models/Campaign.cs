using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DndWebApp.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<User> Users { get; set; }
    }
}