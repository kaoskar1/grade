using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(9.1f);
            book.AddGrade(4.5f);
            book.AddGrade(7.4f);


            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.AvergeGrade);
            Console.WriteLine(stats.AvergeGrade);
            Console.WriteLine(stats.AvergeGrade);
        }
    }
}
