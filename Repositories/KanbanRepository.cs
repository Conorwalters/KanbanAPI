using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace kanban.Repositories
{
    public class KanbanRepository: BaseRepository, IkanbanBoardRepository
    {
        public KanbanRepository(ApiDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<kanbanBoard>> ListAsync()
        {
            return await _context.kanban_table.ToListAsync();
        }
    }
}