using System.Collections.Generic;
using System.Threading.Tasks;
using kanban.Controllers;
using kanban.Repositories;

namespace kanban.Services
{
    public class KanbanBoardService: IKanbanBoardService
    {
        private readonly IkanbanBoardRepository _kanbanBoardRepository;

        public KanbanBoardService(IkanbanBoardRepository kanbanBoardRepository)
        {
            this._kanbanBoardRepository = kanbanBoardRepository;
        }
        
        public async Task<IEnumerable<kanbanBoard>> ListAsync()
        {
            return await _kanbanBoardRepository.ListAsync();
        }
    }
}