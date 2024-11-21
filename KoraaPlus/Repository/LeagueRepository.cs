using KoraaPlus.Data;
using KoraaPlus.Models;
using KoraaPlus.Repository.IRepository;

namespace KoraaPlus.Repository
{
    public class LeagueRepository : Repository<League> , ILeagueRepository
    {
        private readonly ApplicationDbContext dbContext;

        public LeagueRepository(ApplicationDbContext dbContext) : base(dbContext) 
        {
            this.dbContext=dbContext;
        }
    }
}
