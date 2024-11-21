using KoraaPlus.Data;
using KoraaPlus.Models;
using KoraaPlus.Repository.IRepository;

namespace KoraaPlus.Repository
{
    public class MatchRepository : Repository<Match> , IMatchRepository
    {
        private readonly ApplicationDbContext dbContext;

        public MatchRepository(ApplicationDbContext dbContext) : base(dbContext) 
        {
            this.dbContext=dbContext;
        }
    }
}
