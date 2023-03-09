//Maria Waleska Marinho de Oliveira 
//Student Number : 8751749
//email: mmarinhodeoliver1749@conestogac.on.ca
//PROG2230  Sec 4

using System.ComponentModel.DataAnnotations;
namespace MOAssignment1.Entities
{
    //Here is Where we set the propeties 
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Please enter a Fisrt Name!.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter the Last Name!.")]
        public string LastName { get; set; }

      
        public string dataOfBirth { get; set; }

        public double GPA { get; set; }

        public string GPAScale{ get; set; }

        [Required(ErrorMessage = "Please choose a Program ")]
        public string StudentProgramId { get; set; }

        public StudentProgram? Program { get; set; }
    }
}
