namespace SetupYourProject_Filomeno.Services;
using SetupYourProject_Filomeno.Models;
using SetupYourProject_Filomeno.Services;

    public interface IMyFakeDataService
    {
        List<Student> StudentList { get; }

        List<Instructor> InstructorList { get; }
    }


