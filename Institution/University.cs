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

        public void AddStudent(Student student)
        {
            students[student.studentId] = student;
        }

        public void AddStudentsFromArray(Student[] studentsFromArray)
        {
            students = studentsFromArray;
        }
    }
}
