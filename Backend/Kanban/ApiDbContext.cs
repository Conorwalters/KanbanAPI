using Microsoft.EntityFrameworkCore;

namespace kanban {
    public class ApiDbContext : DbContext {
        public ApiDbContext (DbContextOptions<ApiDbContext> options) : base (options) { }
        public DbSet<kanbanBoard> kanban_table { get; set; }
        public DbSet<ticket> tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<kanbanBoard>().ToTable("kanban_table");
            builder.Entity<kanbanBoard>().HasKey(p => p.id);
            builder.Entity<kanbanBoard>().Property(p => p.id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<kanbanBoard>().Property(p => p.description).IsRequired().HasMaxLength(125);
            builder.Entity<kanbanBoard>().HasMany(p => p.tickets).WithOne(p => p.KanbanBoard)
                .HasForeignKey(p => p.KanbanBoardID);

            builder.Entity<kanbanBoard>().HasData
            (
                new kanbanBoard { id = 100, description = "kanbanboard2"}, // Id set manually due to in-memory provider
                new kanbanBoard { id = 101, description = "kanbanboard1"}
            );

            builder.Entity<ticket>().ToTable("ticket");
            builder.Entity<ticket>().HasKey(p => p.Id);
            builder.Entity<ticket>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<ticket>().Property(p => p.description).IsRequired().HasMaxLength(125);
            builder.Entity<ticket>().Property(p => p.label).IsRequired().HasMaxLength(125);
            builder.Entity<ticket>().Property(p => p.type).IsRequired().HasMaxLength(125);
            builder.Entity<ticket>().Property(p => p.status).IsRequired().HasMaxLength(125);
        }
    }
}