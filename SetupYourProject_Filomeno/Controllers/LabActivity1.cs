using Microsoft.AspNetCore.Mvc;
using SetupYourProject_Filomeno.Models;

namespace SetupYourProject_Filomeno.Controllers
{
    public class LabActivity1 : Controller
    {
        List<Student> StudentList = new List<Student>()
            {
                new Student()
                {
                    Id = 1, FirstName = "Cyril", LastName = "Filomeno", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "cyrilangelo.filomeno.cics@ust.edu.ph"
                },
                new Student()
                    {
                    Id = 2, FirstName = "Caster", LastName = "Lapuz", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-27"), GPA = 1.6, Email = "castertroi.lapuz.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id = 3, FirstName = "Rico", LastName = "Nieto", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-28"), GPA = 1.8, Email = "rico.nieto.cics@ust.edu.ph"
                }
            };

        List<Instructor> InstructorList = new List<Instructor>()
            {
                new Instructor()
                {
                    Id = 1, FirstName = "Cyril", LastName = "Filomeno", IsTenured = true, Rank = Rank.Instructor, HiringDate = DateTime.Parse("2022-08-27")
                },
                new Models.Instructor()
                {
                    Id = 2, FirstName = "Caster", LastName = "Lapuz", IsTenured = false, Rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2022-08-28")
                },
                new Models.Instructor()
                {
                    Id = 3, FirstName = "Rico", LastName = "Nieto", IsTenured = true, Rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2022-08-29")
                }
            };

        public IActionResult Index()
        {
            return View(InstructorList);
        }
        public IActionResult Student()
        {
            return View(StudentList);
        }
        public IActionResult ShowDetails(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(Instructor => Instructor.Id == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            return NotFound();
        }

        public IActionResult ShowDetail(int id)
        {
            Student? student = StudentList.FirstOrDefault(Student => Student.Id == id);

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
            InstructorList.Add(newInstructor);
            return View("Index", InstructorList);
        }

        [HttpGet]
        public IActionResult EditInstructor(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(Instructor => Instructor.Id == id);
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
            Instructor? instructor = InstructorList.FirstOrDefault(Instructor => Instructor.Id == InstructorEdit.Id);

            if (instructor != null)
            {
                instructor.Id = InstructorEdit.Id;
                instructor.FirstName = InstructorEdit.FirstName;
                instructor.LastName = InstructorEdit.LastName;
                instructor.IsTenured = InstructorEdit.IsTenured;
                instructor.HiringDate = InstructorEdit.HiringDate;
                instructor.Rank = InstructorEdit.Rank;
            }
            return View("Index", InstructorList);
        }
    }
}

