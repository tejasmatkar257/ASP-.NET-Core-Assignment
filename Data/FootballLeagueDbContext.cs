using Microsoft.EntityFrameworkCore;

namespace FootballLeagueManagement.Models
{
    public class FootballLeagueDbContext : DbContext
    {

        public FootballLeagueDbContext(DbContextOptions<FootballLeagueDbContext> options) : base(options)
        {
        }

        public DbSet<FootballLeague> FootballLeagues { get; set; }
    }
}