using InternshipTest.Person;
using System;
using InternshipTest.Institution;
using System.Collections.Generic;
using System.Text;

namespace internshiptest.Logick
{
    class Filter
    {
        public Student[] interns = new Student[99];

        public Student[] StudentsByKnowledge(University university)
        {

            int knowledge_sum = 0;
            int number = 0;

           foreach (Student i in university.students)
            {
                number++;
                if (i != null) {  knowledge_sum = knowledge_sum + i.studentKnowledge.value; }
                
            }
            knowledge_sum = knowledge_sum / number;
            number = 0;
           
            foreach (Student i in university.students)
            {
                number++;
                if (i != null) { if (i.studentKnowledge.value > knowledge_sum) { interns[number] = i; } }
                    
            }
            return interns;
        }

        
    }
}
