using SetupYourProject_Filomeno.Models;
using System;
using SetupYourProject_Filomeno.Services;

namespace SetupYourProject_Filomeno.Services;

public class MyFakeDataService : IMyFakeDataService
{
    public List<Student> StudentList { get; }
    public List<Instructor> InstructorList { get; } 

    public MyFakeDataService() 
    {
        StudentList = new List<Student>()
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

        InstructorList = new List<Instructor>()
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

    }
    }

