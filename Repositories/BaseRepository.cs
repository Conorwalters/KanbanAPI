namespace kanban.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly ApiDbContext _context;

        public BaseRepository(ApiDbContext context)
        {
            _context = context;
        }
    }
}