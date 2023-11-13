using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SetupYourProject_Filomeno.Data;
using SetupYourProject_Filomeno.Models;
using SetupYourProject_Filomeno.Services;

namespace SetupYourProject_Filomeno.Controllers
{
    public class LabActivity1 : Controller
    {
            private readonly AppDbContext _dbContext;

        public LabActivity1(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.Instructors);
        }
        public IActionResult Student()
        {
            return View(_dbContext.Students);
        }
        public IActionResult ShowDetails(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(Instructor => Instructor.Id == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            return NotFound();
        }
        public IActionResult ShowDetail(int id)
        {
            Student? student = _dbContext.Students.FirstOrDefault(Student => Student.Id == id);

            if (student != null)
            {
                return View(student);
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _dbContext.Instructors.Add(newInstructor);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditInstructor(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(Instructor => Instructor.Id == id);
            if (instructor != null)
            {
                return View(instructor);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult EditInstructor(Instructor InstructorEdit)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(Instructor => Instructor.Id == InstructorEdit.Id);

            if (instructor != null)
            {
                instructor.Id = InstructorEdit.Id;
                instructor.FirstName = InstructorEdit.FirstName;
                instructor.LastName = InstructorEdit.LastName;
                instructor.IsTenured = InstructorEdit.IsTenured;
                instructor.HiringDate = InstructorEdit.HiringDate;
                instructor.Rank = InstructorEdit.Rank;
            }
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(Instructor => Instructor.Id == id);
            if (instructor != null)
            {
                return View(instructor);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult DeleteInstructor(Instructor delInstructor)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(Instructor => Instructor.Id == delInstructor.Id);
            _dbContext.Instructors.Remove(instructor);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _dbContext.Students.Add(newStudent);
            _dbContext.SaveChanges();
            return RedirectToAction("Student");
        }

        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            Student? student = _dbContext.Students.FirstOrDefault(Student => Student.Id == id);
            if (student != null)
            {
                return View(student);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult EditStudent(Student StudentEdit)
        {
            Student? student = _dbContext.Students.FirstOrDefault(Student => Student.Id == StudentEdit.Id);

            if (student != null)
            {
                student.Id = StudentEdit.Id;
                student.FirstName = StudentEdit.FirstName;
                student.LastName = StudentEdit.LastName;
                student.AdmissionDate = StudentEdit.AdmissionDate;
                student.Email = StudentEdit.Email;
                student.GPA = StudentEdit.GPA;
            }
            _dbContext.SaveChanges();
            return RedirectToAction("Student");
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            Student? student = _dbContext.Students.FirstOrDefault(Instructor => Instructor.Id == id);
            if (student != null)
            {
                return View(student);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult DeleteStudent(Student delStudent)
        {
            Student? student = _dbContext.Students.FirstOrDefault(Student => Student.Id == delStudent.Id);
            _dbContext.Students.Remove(student);
            _dbContext.SaveChanges();
            return RedirectToAction("Student");
        }

    }
}

