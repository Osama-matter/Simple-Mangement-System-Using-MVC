using Microsoft.EntityFrameworkCore;

namespace Entity_FreamWork.Models
{
    public class HR_Database_Context : DbContext
    {
        public DbSet<DepartMent> DepartMents { get; set; }
        public DbSet<Employes> Employesses { get; set; }

        public HR_Database_Context(DbContextOptions<HR_Database_Context> options) : base(options)
        {
        }

        public HR_Database_Context()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ContactsDB2;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure table names and schemas
            modelBuilder.Entity<DepartMent>().ToTable("Department", "dbo");
            modelBuilder.Entity<Employes>().ToTable("Employees", "dbo");

            // Configure relationships
            modelBuilder.Entity<Employes>()
                .HasOne(e => e.DepartMent)
                .WithMany()
                .HasForeignKey(e => e.DepartmentID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
