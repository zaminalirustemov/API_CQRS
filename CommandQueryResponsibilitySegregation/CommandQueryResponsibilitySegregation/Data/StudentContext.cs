using Microsoft.EntityFrameworkCore;

namespace CommandQueryResponsibilitySegregation.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student[]
            {
                new Student(){Id=1,Name="Zaminali",Surname="Rustamov",Age=20},
                new Student(){Id=2,Name="Nicat",Surname="Abdullayev",Age=21},
                new Student(){Id=3,Name="Ali",Surname="Ibrahimov",Age=19},
                new Student(){Id=4,Name="Namiq",Surname="Mikayilov",Age=21},
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
