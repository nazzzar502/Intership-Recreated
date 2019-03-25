using InternshipTest.Person;
using System;

namespace InternshipTest.Institution.InterLink
{
    public class Internship : University
    {
        string intershipName;

        public Internship(string name):base(name)
        {
            intershipName = name;
        }

        public void ShowStudents()
        {
            foreach (Student i in students)
            {
                if (i != null)
                {
                    Console.WriteLine(i.studentName);
                    Console.WriteLine(i.studentKnowledge.value);
                }

            }
        }
    }
}
