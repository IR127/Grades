using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
    class GradeBook
    {
        private List<float> grades; //grades is encapsulated

        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
    }
}
