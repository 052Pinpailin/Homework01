using System;
using System;

class UniquePascalTriangle
{
    static void Main()
    {
        while (true)
        {
            int input = ReadPositiveInteger();

            if (input < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
            }
            else
            {
                GeneratePascalTriangle(input);
                break;
            }
        }
    }

    static int ReadPositiveInteger()
    {
        int number;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number) && number > 0)
                return number;
        }
    }

    static void GeneratePascalTriangle(int rows)
    {
        for (int row = 0; row <= rows; row++)
        {
            for (int column = 0; column <= row; column++)
            {
                int coefficient = CalculateCoefficient(row, column);
                Console.Write($"{coefficient} ");
            }
            Console.WriteLine();
        }
    }

    static int CalculateCoefficient(int row, int column)
    {
        int numerator = CalculateFactorial(row);
        int denominator = CalculateFactorial(row - column) * CalculateFactorial(column);
        return numerator / denominator;
    }

    static int CalculateFactorial(int number)
    {
        if (number <= 1)
            return 1;
        return number * CalculateFactorial(number - 1);
    }
}
