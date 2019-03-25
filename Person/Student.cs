namespace InternshipTest.Person
{
    public class Student
       
    {
        public Knowledge studentKnowledge;
        public string studentName;
        public int studentId;

        public Student(string name, int Id)
        {
            studentName = name;
            studentId = Id;
           
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            studentKnowledge = knowledge;
        }
    }
}