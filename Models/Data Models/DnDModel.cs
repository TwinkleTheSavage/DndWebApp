using System.Data.Entity;

namespace DndWebApp.Models.Data_Models
{
    public class DnDModel : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
    }
}