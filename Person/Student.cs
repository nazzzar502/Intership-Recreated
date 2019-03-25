namespace InternshipTest.Person
{
    public class Student
       
    {
        private Knowledge studentKnowledge;
        private string studentName;
        private int studentId;

        public Student(string name, int Id)
        {
            studentName = name;
            studentId = Id;
           
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            studentKnowledge = knowledge;
        }

        public string GetstudentName()
        {
            return studentName;
        }

        public Knowledge GetstudentKnowledge()
        {
            return studentKnowledge;
        }

        public int GetstudentId()
        {
            return studentId;
        }
    }
}