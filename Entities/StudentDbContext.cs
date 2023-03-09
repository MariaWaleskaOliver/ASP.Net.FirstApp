//Maria Waleska Marinho de Oliveira 
//Student Number : 8751749
//email: mmarinhodeoliver1749@conestogac.on.ca
//PROG2230  Sec 4

using Microsoft.EntityFrameworkCore;
//Here is where we manage the dataBase 
namespace MOAssignment1.Entities
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
         : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentProgram> Program { get; set; }
       
        //Here is where we set the programa Id and name 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentProgram>().HasData(
                new StudentProgram() { StudentProgramId = "CP", Name = "ComputerPorgramming" },
                new StudentProgram() { StudentProgramId = "CPI", Name = "ComputerPorgramming" },
                new StudentProgram() { StudentProgramId = "NU", Name = "Nursing" },
                new StudentProgram() { StudentProgramId = "CA", Name = "Carpinter" },
                new StudentProgram() { StudentProgramId = "CO", Name = "Cooking" },
                new StudentProgram() { StudentProgramId = "BI", Name = "Busnessis" },
                new StudentProgram() { StudentProgramId = "HO", Name = "Hotel" },
                new StudentProgram() { StudentProgramId = "PB", Name = "Plumber" }
                );
            //Here is where i created some Students
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    StudentId = 1,
                    FirstName = "Maria",
                    LastName = "Oliveira",
                    dataOfBirth = "17/08/1997",
                    GPAScale = "good",
                    GPA = 2.5,
                    StudentProgramId = "CP"

                },
                new Student()
                {
                    StudentId = 2,
                    FirstName = "Jose",
                    LastName = "Oliveira",
                    dataOfBirth = "17/08/1997",
                    GPAScale = "good",
                    GPA = 4.5,
                    StudentProgramId = "NU"
                },
                new Student()
                {
                    StudentId = 3,
                    FirstName = "Carlos",
                    LastName = "Oliveira",
                    dataOfBirth = "17/08/1997",
                    GPAScale = "good",
                    GPA = 3.5,
                    StudentProgramId = "PB"
                }
            
            ) ;
        }
    }
}
