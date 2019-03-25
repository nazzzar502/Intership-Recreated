namespace InternshipTest.Person
{
    public class Student
       
    {
        public Knowledge studentknowledge;
        public string studentname;

        public Student(string name, Knowledge knowledge)
        {
            studentname = name;
           
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            studentknowledge = knowledge;
        }
    }
}