using AutoMapper;
using kanban.Resources;
namespace kanban.Mapping
{
    public class ResourceToModelProfile: Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveKanbanBoardResource, kanbanBoard>();
        }
    }
}