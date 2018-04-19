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



        public string Descprition {

            get
            {
                string result;
                switch (LetterGrade)
                { 
                    case 'A':
                    result = "Excellent";
                        break;

                    case 'B':
                    result = "Dunder";
                        break;

                    case 'C':
                    result = "Helt Okej";
                        break;

                    case 'D':
                    result = "Pkej";
                        break;

                    default:
                        result = "Fail";
                        break;

                        }
                return result;
            }
        } 

        public char LetterGrade
        {
            get
            {
                char result;
                if (AvergeGrade >= 90)
                {
                    return 'A';
                }
                else if (AvergeGrade >= 80)
                {
                    return 'B';
                }
                else if (AvergeGrade >= 70)
                {
                    return 'C';
                }
                else if (AvergeGrade >= 60)
                {
                    return 'D';
                }
                else
                {
                   return 'F';
                }
                    return result;
                }
            }
        }
    }

