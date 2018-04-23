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
            IGradeTracker book = CreateGradeBook();

            try
            {
                using (FileStream stream = File.Open("grades.txt", FileMode.Open))
                using (StreamReader reader = new StreamReader(stream))
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
            catch (FileNotFoundException)
            {

                //                Console.WriteLine("File not found din hound");
                return;
            }
            catch (UnauthorizedAccessException)
            {

                Console.WriteLine("none vaild access");
                return;
            }
            foreach (float grade in book)
            {
                Console.WriteLine();
            }

            try
            {

                //Console.WriteLine("PLease skriv nogt do ");
                //book.Name = Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("felaktigt namn");
            }


            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.AvergeGrade);
            Console.WriteLine(stats.HighGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine("{0} {1}", stats.LetterGrade, stats.Descprition);
        }

        private static IGradeTracker CreateGradeBook()
        {
            IGradeTracker  book = new ThrowAwayGradeBook("Scotts baok");
            return new ThrowAwayGradeBook("barrfens");
        }
    }
}

