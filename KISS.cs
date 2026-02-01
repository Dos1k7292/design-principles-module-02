using System;

public class KissExamples
{
    public void ProcessNumbers(int[] numbers)
    {
        if (numbers == null) return;

        foreach (var number in numbers)
        {
            if (number > 0)
                Console.WriteLine(number);
        }
    }

    public void PrintPositiveNumbers(int[] numbers)
    {
        foreach (var number in numbers)
        {
            if (number > 0)
                Console.WriteLine(number);
        }
    }

    public int Divide(int a, int b)
    {
        if (b == 0) return 0;
        return a / b;
    }
}
