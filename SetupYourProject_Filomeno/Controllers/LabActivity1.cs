using Microsoft.AspNetCore.Mvc;
using SetupYourProject_Filomeno.Models;
using SetupYourProject_Filomeno.Services;

namespace SetupYourProject_Filomeno.Controllers
{
    public class LabActivity1 : Controller
    {
            private readonly IMyFakeDataService _fakeData;

        public LabActivity1(IMyFakeDataService fakeData)
        {
            _fakeData = fakeData;
        }

        public IActionResult Index()
        {
            return View(_fakeData.InstructorList);
        }
        public IActionResult Student()
        {
            return View(_fakeData.StudentList);
        }
        public IActionResult ShowDetails(int id)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(Instructor => Instructor.Id == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            return NotFound();
        }
        public IActionResult ShowDetail(int id)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(Student => Student.Id == id);

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
            _fakeData.InstructorList.Add(newInstructor);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditInstructor(int id)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(Instructor => Instructor.Id == id);
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
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(Instructor => Instructor.Id == InstructorEdit.Id);

            if (instructor != null)
            {
                instructor.Id = InstructorEdit.Id;
                instructor.FirstName = InstructorEdit.FirstName;
                instructor.LastName = InstructorEdit.LastName;
                instructor.IsTenured = InstructorEdit.IsTenured;
                instructor.HiringDate = InstructorEdit.HiringDate;
                instructor.Rank = InstructorEdit.Rank;
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(Instructor => Instructor.Id == id);
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
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(Instructor => Instructor.Id == delInstructor.Id);
            _fakeData.InstructorList.Remove(instructor);
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
            _fakeData.StudentList.Add(newStudent);
            return RedirectToAction("Student");
        }

        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(Student => Student.Id == id);
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
            Student? student = _fakeData.StudentList.FirstOrDefault(Student => Student.Id == StudentEdit.Id);

            if (student != null)
            {
                student.Id = StudentEdit.Id;
                student.FirstName = StudentEdit.FirstName;
                student.LastName = StudentEdit.LastName;
                student.AdmissionDate = StudentEdit.AdmissionDate;
                student.Email = StudentEdit.Email;
                student.GPA = StudentEdit.GPA;
            }
            return RedirectToAction("Student");
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(Instructor => Instructor.Id == id);
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
            Student? student = _fakeData.StudentList.FirstOrDefault(Student => Student.Id == delStudent.Id);
            _fakeData.StudentList.Remove(student);
            return RedirectToAction("Student");
        }

    }
}

