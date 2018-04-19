using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook(string name = "There is No Name")
        {
            Name = name;
            _grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            
            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);
            }
        }
        
        public GradeStatistics ComputeStatistics()
        {
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



        public void WriteGrade(TextWriter textWriter)
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

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {


                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Hata alla f;r du kan inte skriva");
                }
                if (_name != value)
                {
                    var oldValue = _name;
                    _name = value;
                    if (NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.OldValue = oldValue;
                        args.NewValue = value;
                        NameChanged(this, args);
                    }
                }
            }
        }

        public event NameChangedDelegate NameChanged;
        private List<float> _grades;
    }

}
