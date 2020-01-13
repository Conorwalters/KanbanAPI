using System.Collections.Generic;

namespace kanban
{
    public class ticket
    {
        public string Id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string label { get; set; }
        public string status { get; set; }
        
        public int KanbanBoardID { get; set; }
        public kanbanBoard KanbanBoard { get; set; }
    }
}