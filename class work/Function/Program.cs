using System;
using Function;

internal class Program
{
    private static void Main(string[] args)
    {

        FunctionOverloading functionOverloading = new FunctionOverloading();
        // Integer addition
        int intAddResult = functionOverloading.Add(5, 10);
        Console.WriteLine("Addition of two integers: " + intAddResult);

        // Double addition
        double doubleAddResult = functionOverloading.Add(5.5, 10.2);
        Console.WriteLine("Addition of two doubles: " + doubleAddResult);

        // Integer multiplication
        int intMultiplyResult = functionOverloading.Multiply(5, 10);
        Console.WriteLine("Multiplication of two integers: " + intMultiplyResult);

        // Double multiplication
        double doubleMultiplyResult = functionOverloading.Multiply(5.5, 10.2);
        Console.WriteLine("Multiplication of two doubles: " + doubleMultiplyResult);

        Console.ReadLine(); // To keep the console window open
        Console.Clear();


        ///////////////////////////////////////////program of inheritance

        MathOperation operation = new MathOperation();
        Console.WriteLine("Addition: " + operation.Add(70, 5));
        Console.WriteLine("Subtraction: " + operation.Subtract(10, 7));
        Console.WriteLine("Multiplication: " + operation.Multiply(10, 4));
        Console.WriteLine("Division: " + operation.Divide(14, 5));
        //Console.Clear();


        ///////////////////////////////////////////inhertance_qns program

        AdvancedOperations operation = new AdvancedOperations();
        // Call inherited methods
        double additionResult = operation.Add(55, 5);
        double subtractionResult = operation.Subtract(40, 5);
        double multiplicationResult = operation.Multiply(1, 5);
        double divisionResult = operation.Divide(0, 5);
        Console.WriteLine("Addition Result: " + additionResult);
        Console.WriteLine("Subtraction Result: " + subtractionResult);
        Console.WriteLine("Multiplication Result: " + multiplicationResult);
        Console.WriteLine("Division Result: " + divisionResult);


        //////////////////////////////////////////funcn overridng program

        AdvancedOperations operation = new AdvancedOperations();
        double additionResult = operation.Add(8, 5);
        double subtractionResult = operation.Subtract(0, 1);
        double multiplicationResult = operation.Multiply(40, 5);
        double divisionResult = operation.Divide(10, 11);
        Console.WriteLine("Addition Result: " + additionResult);
        Console.WriteLine("Subtraction Result: " + subtractionResult);
        Console.WriteLine("Multiplication Result: " + multiplicationResult);
        Console.WriteLine("Division Result: " + divisionResult);



    }
}