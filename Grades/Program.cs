using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {


    static void Main(string[] args)
        {


         GradeBook book = new GradeBook();
         book.AddGrade(91f);
         book.AddGrade(89.1f);
         book.AddGrade(75f);


         GradeStatistics stats = book.ComputeStatistics();

          WriteBytes(stats.AvergeGrade);

         Console.WriteLine(stats.AvergeGrade);
         Console.WriteLine(stats.HighGrade);
         Console.WriteLine(stats.LowestGrade);
        }

        private static void WriteBytes(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            foreach (byte b in bytes)
            {
                Console.Write("0x{0}", b );
            }
            Console.WriteLine();
        }
    }

}

