using System.Data.Entity;
using web.Models.Arts;
using web.Models.Music;

namespace web.Models
{
    public class MuseumDBContext : DbContext
    {
        public DbSet<Art> Arts { get; set; }
        public DbSet<Musics> Musics_DbSet { get; set; }
    }
}
