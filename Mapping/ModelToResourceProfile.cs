using AutoMapper;
using kanban.Resources;

namespace kanban.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<kanbanBoard, kanbanBoardResource>();
        }
    }
}