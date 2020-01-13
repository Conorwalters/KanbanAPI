using System.Collections.Generic;
using System.Threading.Tasks;
using kanban.Services.Communication;

namespace kanban.Controllers
{
    public interface IKanbanBoardService{
        Task<IEnumerable<kanbanBoard>> ListAsync();
        Task<SaveKanbanBoardResponse> SaveAsync(kanbanBoard kanbanBoard);
    }
}