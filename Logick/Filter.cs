using InternshipTest.Person;
using System;
using InternshipTest.Institution;
using System.Collections.Generic;
using System.Text;

namespace internshiptest.Logick
{
    class Filter
    {
        string filtername;

        public Filter(string name)
        {
            filtername = name;
        }

        public Student[] interns = new Student[99];

        public Student[] StudentsByKnowledge(University university)
        {

            int knowledge_sum = 0;
            int number = 0;
            int count = 0;

           foreach (Student i in university.GetStudents())
            {
                
                if (i != null) {  knowledge_sum = knowledge_sum + i.GetstudentKnowledge().GetValue(); number++; }
                
            }
            knowledge_sum = knowledge_sum / number;
           
           
            foreach (Student i in university.GetStudents())
            {
                count++;
                if (i != null) { if (i.GetstudentKnowledge().GetValue() > knowledge_sum) { interns[count] = i; } }
                    
            }
            return interns;
        }

        
    }
}
