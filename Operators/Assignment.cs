using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC__.Operators
{
    internal class Assignment
    {
        public float AddAndAssignment(float x, float y)
        {
            return x += y;
        }
        public float SubtractAndAssignment(float x, float y)
        {
            return x -= y;
        }
        public float MultiplyAndAssignment(float x, float y)
        {
            return x *= y;
        }
        public float DivideAndAssignment(float x, float y)
        {
            return x /= y;
        }

        public (int quotient, int remainder) ModAssignment(int dividend, int divisor)
        {
            var remainder = dividend%divisor;
            dividend /= divisor;
            
            return (dividend , remainder);
        }
    }
}
