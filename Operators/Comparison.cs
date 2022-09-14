using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC__.Operators
{
    public class Comparison
    {
        public bool GreaterThan(int numA, int numB)
        {
            return numA > numB;
        }
        public bool GreaterThanOrEqual(int numA, int numB)
        {
            return numA >= numB;
        }
        public bool LessThan(int numA, int numB)
        {
            return numA < numB;
        }
        public bool LessThanOrEqual(int numA, int numB)
        {
            return numA <= numB;
        }

        public bool BetweenTwoNumbers(int value, int lowerLimit, int upperLimit)
        {
            if (GreaterThan(value, lowerLimit) && LessThan(value, upperLimit)) 
            { 
                return true; 
            }
            else if (GreaterThanOrEqual(value, lowerLimit) && LessThan(value, upperLimit)) 
            { 
                return true;
            }
            else if (GreaterThan(value, lowerLimit) && LessThanOrEqual(value, upperLimit))
            {
                return true;
            }
            else if (GreaterThanOrEqual(value, lowerLimit) && LessThanOrEqual(value, upperLimit))
            {
                return true;
            }
            return false;
        }

        public string PositiveOrNegative(float valueA)
        {
            if (valueA > 0)
            {
                return "number is positive";
            }
            else if (valueA < 0)
            {
                return "number is negative";
            }
            return "number is zero";
        }
    }
}
