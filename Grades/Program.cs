using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.IO;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook("Black Book");

            try
            {
               using(FileStream stream = File.Open("grades.txt", FileMode.Open))
               using (StreamReader  reader = new StreamReader(stream)) 
                {
                
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        float grade = float.Parse(line);
                        book.AddGrade(grade);
                        line = reader.ReadLine();
                    }

                }
            }
            catch (FileNotFoundException ex)
            {

//                Console.WriteLine("File not found din hound");
                return;
            }
            catch (UnauthorizedAccessException ex)
            {

                Console.WriteLine("none vaild access");
                return;
            }


            book.WriteGrade(Console.Out);

            try
            {

                Console.WriteLine("PLease skriv nogt do ");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("felaktigt namn");
            }


            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.AvergeGrade);
            Console.WriteLine(stats.HighGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine("{0} {1}", stats.LetterGrade, stats.Descprition);
        }
    }
}

