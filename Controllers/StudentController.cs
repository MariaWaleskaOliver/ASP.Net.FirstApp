//Maria Waleska Marinho de Oliveira 
//Student Number : 8751749
//email: mmarinhodeoliver1749@conestogac.on.ca
//PROG2230  Sec 4

using Microsoft.AspNetCore.Mvc;
using MOAssignment1.Entities;
using MOAssignment1.Models;

// Here is where we manage the Edit and Delete features of the program  

namespace MOAssignment1.Controllers
{
    //Constructor 
    public class StudentController : Controller
    {
        public StudentController(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }

        //Edit  Get and Post :

        [HttpGet()]

        public IActionResult Edit(int id)
        {
            StudentViewModel studentViewModel = new StudentViewModel()
            {
                Programs = _studentDbContext.Program.OrderBy(g => g.Name).ToList(),
                ActiveStudent = _studentDbContext.Students.Find(id)
            };

            return View(studentViewModel);
        }
        [HttpPost()]

        public IActionResult Edit(StudentViewModel studentViewModel)
        {
            //Check to see if it valid, if so we update in the data base
            if (ModelState.IsValid)
            {
                
                _studentDbContext.Students.Update(studentViewModel.ActiveStudent);
                _studentDbContext.SaveChanges();
                return RedirectToAction("List", "Students");
            }
            else
            {
                studentViewModel.Programs = _studentDbContext.Program.OrderBy(g => g.Name).ToList();
                return View(studentViewModel);
            }
        }
        //Delete  Get and Post :

        [HttpGet()]

        public IActionResult Delete(int id)
        {
            //Find the Student Id 
            var student = _studentDbContext.Students.Find(id);
            return View(student);
        }

        //Delete the Student

        [HttpPost()]

        public IActionResult Delete(Student student)
        {
            _studentDbContext.Students.Remove(student);
            _studentDbContext.SaveChanges();
            return RedirectToAction("List", "Students");
        
    }
        private StudentDbContext _studentDbContext;
    }
}
