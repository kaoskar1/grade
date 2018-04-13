using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;

namespace Grades
{
   public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }


        }


        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0f;

            foreach (float grade in grades) {
               
                {
                    stats.HighGrade = Math.Max(grade, stats.HighGrade);
                    stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                }
                sum += grade;
            }
            stats.AvergeGrade = sum / grades.Count;
            return stats;
        }

        public string Name;

        private List<float> grades;


    }

}
