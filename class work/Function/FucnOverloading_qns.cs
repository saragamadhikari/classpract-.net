using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class FucnOverloading_qns
    {
        // Base class: MathOperations
        class MathOperations
        {
            // Base method for addition (can be overridden)
            public virtual double Add(double a, double b)
            {
                return a + b;
            }

            // Base method for subtraction (can be overridden)
            public virtual double Subtract(double a, double b)
            {
                return a - b;
            }

            // Base method for multiplication (can be overridden)
            public virtual double Multiply(double a, double b)
            {
                return a * b;
            }

            // Base method for division (can be overridden)
            public virtual double Divide(double a, double b)
            {
                if (b == 0)
                    throw new DivideByZeroException("Cannot divide by zero.");
                return a / b;
            }
        }

        // Derived class: AdvancedOperations
        class AdvancedOperations : MathOperations
        {
            // Overriding the Add method
            public override double Add(double a, double b)
            {
                Console.WriteLine("Performing Addition (Overridden):");
                return base.Add(a, b); // Calling base class method
            }

            // Overriding the Subtract method
            public override double Subtract(double a, double b)
            {
                Console.WriteLine("Performing Subtraction (Overridden):");
                return base.Subtract(a, b); // Calling base class method
            }

            // Overriding the Multiply method
            public override double Multiply(double a, double b)
            {
                Console.WriteLine("Performing Multiplication (Overridden):");
                return base.Multiply(a, b); // Calling base class method
            }

            // Overriding the Divide method
            public override double Divide(double a, double b)
            {
                Console.WriteLine("Performing Division (Overridden):");
                return base.Divide(a, b); // Calling base class method
            }
        }

    }
}
