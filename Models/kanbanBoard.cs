using System.Collections.Generic;

namespace kanban {
    public class kanbanBoard {
        public int id { get; set; }
        public string description { get; set; }
        public IList<ticket> tickets { get; set; } = new List<ticket>();

    }
}