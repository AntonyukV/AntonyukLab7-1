using System;

public class Calculator<T>
{
    // Делегат для арифметичних операцій
    public delegate T ArithmeticOperationDelegate(T x, T y);

    // Делегати для конкретних арифметичних операцій
    public ArithmeticOperationDelegate Add { get; } = (x, y) => (dynamic)x + y;
    public ArithmeticOperationDelegate Subtract { get; } = (x, y) => (dynamic)x - y;
    public ArithmeticOperationDelegate Multiply { get; } = (x, y) => (dynamic)x * y;
    public ArithmeticOperationDelegate Divide { get; } = (x, y) => (dynamic)x / y;

    // Метод для виконання арифметичних операцій
    public T PerformOperation(ArithmeticOperationDelegate operation, T x, T y)
    {
        return operation(x, y);
    }
}

class Program
{
    static void Main()
    {
        // Використання калькулятора для цілих чисел
        Calculator<int> intCalculator = new Calculator<int>();
        int resultIntAdd = intCalculator.PerformOperation(intCalculator.Add, 5, 3);
        int resultIntSubtract = intCalculator.PerformOperation(intCalculator.Subtract, 5, 3);
        int resultIntMultiply = intCalculator.PerformOperation(intCalculator.Multiply, 5, 3);
        int resultIntDivide = intCalculator.PerformOperation(intCalculator.Divide, 5, 3);

        Console.WriteLine($"Integer Calculator Results: Add - {resultIntAdd}, Subtract - {resultIntSubtract}, Multiply - {resultIntMultiply}, Divide - {resultIntDivide}");

        // Використання калькулятора для чисел з плаваючою комою
        Calculator<double> doubleCalculator = new Calculator<double>();
        double resultDoubleAdd = doubleCalculator.PerformOperation(doubleCalculator.Add, 5.0, 3.0);
        double resultDoubleSubtract = doubleCalculator.PerformOperation(doubleCalculator.Subtract, 5.0, 3.0);
        double resultDoubleMultiply = doubleCalculator.PerformOperation(doubleCalculator.Multiply, 5.0, 3.0);
        double resultDoubleDivide = doubleCalculator.PerformOperation(doubleCalculator.Divide, 5.0, 3.0);

        Console.WriteLine($"Double Calculator Results: Add - {resultDoubleAdd}, Subtract - {resultDoubleSubtract}, Multiply - {resultDoubleMultiply}, Divide - {resultDoubleDivide}");
    }
}

