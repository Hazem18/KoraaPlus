using KoraaPlus.Data;
using KoraaPlus.Models;
using KoraaPlus.Repository.IRepository;

namespace KoraaPlus.Repository
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        private readonly ApplicationDbContext dbContext;

        public TeamRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext=dbContext;
        }
    }
}
