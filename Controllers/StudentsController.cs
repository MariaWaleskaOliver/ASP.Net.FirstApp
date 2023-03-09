//Maria Waleska Marinho de Oliveira 
//Student Number : 8751749
//email: mmarinhodeoliver1749@conestogac.on.ca
//PROG2230  Sec 4


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MOAssignment1.Entities;
using MOAssignment1.Models;

// Here is where we manage the List and Create features of the program  
namespace MOAssignment1.Controllers
{
    public class StudentsController : Controller
    {
        //Constructor 
        public StudentsController(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }

        [HttpGet()]
        public IActionResult List()
        {
            //List all the students List 
            var allStudents = _studentDbContext.Students.ToList();
            return View(allStudents);
        }

        [HttpGet()]
        //Where we are creating a new Student 
        public IActionResult Create()
        {
           StudentViewModel studentViewModel = new StudentViewModel()
            {
                Programs = _studentDbContext.Program.OrderBy(g => g.Name).ToList(),
                ActiveStudent = new Student()
            };

            return View(studentViewModel);
        }

        [HttpPost()]

        public IActionResult Create(StudentViewModel studentViewModel)
        {
            //Check to see if it valid, if so we update in the data base
            if (ModelState.IsValid)
            {
                _studentDbContext.Students.Add(studentViewModel.ActiveStudent);
                _studentDbContext.SaveChanges();
                return RedirectToAction("List", "Students");
            }
            else
            {
                //If no we still in the edit mode
                studentViewModel.Programs = _studentDbContext.Program.OrderBy(g => g.Name).ToList();
                return View(studentViewModel);
            }
        }
        
        private StudentDbContext _studentDbContext;
    }
}
