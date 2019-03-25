using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public class University
    {
        protected Student[] students = new Student[99];
        string universityName;
        public University(string name)
        {
            universityName = name;
        }

        public Student[] GetStudents(){ return students; }

        public void AddStudent(Student student)
        {
            students[student.GetstudentId()] = student;
        }

        public void AddStudentsFromArray(Student[] studentsFromArray)
        {
            students = studentsFromArray;
        }
    }
}
