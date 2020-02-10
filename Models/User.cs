using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DndWebApp.Models
{
    public class User
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<Campaign> Campaigns { get; set; }
    }
}