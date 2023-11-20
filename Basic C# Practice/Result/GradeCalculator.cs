using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result
{
    internal class GradeCalculator
    {
        public double mathScore;
        public double physicsScore;
        public double chemistryScore;

        public double GetAvgScore()
        {
            return (mathScore + physicsScore+ chemistryScore)/3;
        }

        public string GetOverallGrade()
        {
            return GetGrade(GetAvgScore());
        }

        public string GetMathGrade()
        {
            return GetGrade(mathScore);
        }

        public string GetPhysicsGrade()
        {
            return GetGrade(physicsScore);
        }

        public string GetChemistryGrade()
        {
            return GetGrade(chemistryScore);
        }

        public string GetGrade(double score)
        {
            if(score >= 90 && score<=100) 
            {
                return "A+";
            }

            else if (score >= 80 && score < 90)
            {
                return "B+";
            }

            else if (score >= 70 && score < 80)
            {
                return "C+";
            }

            else if(score >=0 &&  score <70)
            {
                return "F";
            }

            else
            {
                return null;
            }
        }
    }
}
