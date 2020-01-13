using System.Collections.Generic;
using System.Threading.Tasks;

namespace kanban.Repositories
{
    public interface IkanbanBoardRepository
    {
        Task<IEnumerable<kanbanBoard>> ListAsync();
    }
}