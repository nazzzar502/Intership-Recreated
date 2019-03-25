using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public class University
    {
        public Student[] students = new Student[99];
        string universityName;
        public University(string name)
        {
            universityName = name;
        }

        public void AddStudents(Student student)
        {
            students[student.studentId] = student;
        }
    }
}
