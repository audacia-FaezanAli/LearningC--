using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC__.Operators
{
    public class Arithmetic
    {
        public decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public decimal Subtract(decimal x, decimal y)
        {
            return x - y;
        }
        public decimal Multiply(decimal x, decimal y)
        {
            return x * y;
        }
        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }
        public double Exponentiation(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }
        public int Modulus(int dividend, int divisor)
        {
            return dividend % divisor;
        }
        public double Increment(double x)
        {
            x++;
            return x;
        }
        public float Decrement(float x)
        {
            x--;
            return x;
        }
        public (int quotient, int remainder) Mod(int dividend, int divisor)
        {
            var quotient = dividend / divisor;
            var remainder = dividend % divisor;
            return (quotient, remainder);
        }
        public void FibonacciCalc(int numA=0, int numB=1)
        {
            var count = 0;
            var numC = 0;
            Console.WriteLine(numA);
            while (count < 10)
            {
                count++;
                numC = numA + numB;
                numA = numB;
                numB = numC;
                Console.WriteLine(numA);
            }
            
        }
        public bool PerfectSquare(int number)
        {
            var squareRoot = Math.Sqrt(number);
            if (squareRoot%1 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
