﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;

namespace Grades
{
    public  class GradeBook : GradeTracker 
    {
        public GradeBook(string name = "There is No Name")
        {
            Console.WriteLine("gradebok bajen");

            Name = name;
            _grades = new List<float>();
        }

        public override IEnumerator GetEnumerator()
        {
            return _grades.GetEnumerator(); 
        }

        public override void DoSomething()
        {
            
        }

        public override void AddGrade(float grade)
        {
            
            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);
            }
        }
        
        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("GradeBook Compute");

            GradeStatistics stats = new GradeStatistics();
            float sum = 0f;

            foreach (float grade in _grades)
            {

                {
                    stats.HighGrade = Math.Max(grade, stats.HighGrade);
                    stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                }
                sum += grade;
            }
            stats.AvergeGrade = sum / _grades.Count;
            return stats;
        }



        public override void WriteGrade(TextWriter textWriter)
        {
            textWriter.WriteLine("BETYG BREEE:");


            int i = 0;
            do
            {
                textWriter.WriteLine(_grades[i]);
                i++;
            } while (i < _grades.Count);
            textWriter.WriteLine("----------------");
        }

        //private string _name;
       
        protected List<float> _grades;
    }

}
