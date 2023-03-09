//Maria Waleska Marinho de Oliveira 
//Student Number : 8751749
//email: mmarinhodeoliver1749@conestogac.on.ca
//PROG2230  Sec 4
 

using MOAssignment1.Entities;

namespace MOAssignment1.Models
{
    //Here we set a list of Program and the activeStudent
    public class StudentViewModel
    {
        public List<StudentProgram>? Programs { get; set; } 
        public Student ActiveStudent { get; set; }  

    }
}
