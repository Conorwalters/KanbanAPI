using System.ComponentModel.DataAnnotations;

namespace kanban.Resources
{
    public class SaveKanbanBoardResource
    {
        [Required] [MaxLength(150)] public string description;
    }
}