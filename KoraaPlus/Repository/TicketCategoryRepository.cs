using KoraaPlus.Data;
using KoraaPlus.Models;
using KoraaPlus.Repository.IRepository;

namespace KoraaPlus.Repository
{
    public class TicketCategoryRepository : Repository<TicketCategory>, ITicketCategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public TicketCategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext=dbContext;
        }
    }
}
