using System;
using InternshipTest.Person;
using InternshipTest.Institution;

using InternshipTest.Institution.InterLink;
using internshiptest.Logick;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            University university = new University("CH.U.I.");
            Internship intership = new Internship("Interlink");
                
            Filter i = new Filter("internfilter");

            Knowledge A = new Knowledge(100);
            Knowledge B = new Knowledge(80);
            Knowledge C = new Knowledge(60);
            Knowledge D = new Knowledge(45);
            Knowledge F = new Knowledge(30);


            Student s1 = new Student("Andrew ", 1);
            Student s2 = new Student("Daniel", 2);
            Student s3 = new Student("Michael", 3);
            Student s4 = new Student("Tony", 4);

            s1.SetKnowledge(A);
            s2.SetKnowledge(B);
            s3.SetKnowledge(C);
            s4.SetKnowledge(D);
            




            university.AddStudent(s1);
            university.AddStudent(s2);
            university.AddStudent(s3);
            university.AddStudent(s4);

            

            intership.AddStudentsFromArray(i.StudentsByKnowledge(university));

            intership.ShowStudents();
            Console.ReadLine();




        }
    }
}
