namespace kanban.Services.Communication
{
    public class SaveKanbanBoardResponse: BaseResponse
    {
        public kanbanBoard kanbanBoard { get; private set; }

        private SaveKanbanBoardResponse(bool success, string message, kanbanBoard kanbanBoard): base(success, message)
        {
            kanbanBoard = kanbanBoard;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="kanbanBoard">Saved kanbanBoard.</param>
        /// <returns>Response.</returns>
        public SaveKanbanBoardResponse(kanbanBoard kanbanBoard) : this(true, string.Empty, kanbanBoard)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public SaveKanbanBoardResponse(string message) : this(false, message, null)
        { }
    }
}