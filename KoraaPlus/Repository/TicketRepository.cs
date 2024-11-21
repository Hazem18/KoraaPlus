using KoraaPlus.Data;
using KoraaPlus.Models;
using KoraaPlus.Repository.IRepository;

namespace KoraaPlus.Repository
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        private readonly ApplicationDbContext dbContext;

        public TicketRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext=dbContext;
        }
    }
}
