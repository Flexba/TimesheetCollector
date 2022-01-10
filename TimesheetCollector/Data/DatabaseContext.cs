using Microsoft.EntityFrameworkCore;

namespace TimesheetCollector.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<FileUploadEntity> FileUploads { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=timesheet;Username=postgres;Password=postgres");
        }
    }
}
