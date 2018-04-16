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


            GradeBook book = new GradeBook("Skars Bok");
            book.AddGrade(91f);
            book.AddGrade(89.1f);
            book.AddGrade(75f);




            GradeStatistics stats = book.ComputeStatistics();

           
            WriteNames(book.Name);

            int number = 20;
            WriteBytes(number);
            WriteBytes(stats.AvergeGrade);

            Console.WriteLine(stats.AvergeGrade);
            Console.WriteLine(stats.HighGrade);
            Console.WriteLine(stats.LowestGrade);
        }


        private static void WriteBytes(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteByteArray(bytes);
        }


        private static void WriteBytes(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteByteArray(bytes);
        }

        private static void WriteByteArray(byte[] bytes)
        {

            foreach (byte b in bytes)
            {
                Console.Write("0x{0:X}", b);
            }
            Console.WriteLine();
        }

        private static void WriteNames(params string[] names)
        {
        foreach (string name in names)
	    {
            Console.WriteLine(name);
    	    }

        }
    }

}

