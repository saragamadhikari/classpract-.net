using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class FunctionOverloading
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to add two doubles
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Method to multiply two integers
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Method to multiply two doubles
        public double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
