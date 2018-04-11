using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {

        static void GiveBookAName(GradeBook book)
        {
            book = GradeBook();
            book.Name = "BillBorns Manualen";
        }
 
        static void IncrementNumber(int number)
          {
                number += 1;
          }

    static void Main(string[] args)
        {


            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;


            GiveBookAName(g2);
            Console.WriteLine(g2.Name);
            //hata aik 

            int x1 = 4;
            IncrementNumber(x1);

            Console.WriteLine(x1);


            //GradeBook book = new GradeBook();
            //book.AddGrade(9.1f);
            //book.AddGrade(4.5f);
            //book.AddGrade(7.4f);


            //GradeStatistics stats = book.ComputeStatistics();

            //Console.WriteLine(stats.AvergeGrade);
            //Console.WriteLine(stats.AvergeGrade);
            //Console.WriteLine(stats.AvergeGrade);
        }
    }

}

