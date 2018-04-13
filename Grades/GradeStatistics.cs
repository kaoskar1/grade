using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighGrade = 0;
            LowestGrade = float.MaxValue;
        }

      public float HighGrade;
      public float AvergeGrade;
      public float LowestGrade;


    }
}
