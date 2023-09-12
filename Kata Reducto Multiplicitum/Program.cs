using System;

public class Reducer
{
    public static int SumDigProd(params int[] nums)
    {
        // Sum all numbers
        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }

        // Multiplying digits of the number until we get a single-digit number
        while (sum > 9)
        {
            int product = 1;
            while (sum > 0)
            {
                product *= sum % 10;
                sum /= 10;
            }
            sum = product;
        }

        return sum;
    }
}

public class Test
{
    public static void Main()
    {
        Console.WriteLine(Reducer.SumDigProd(0));  // Should print 0
        Console.WriteLine(Reducer.SumDigProd(9));  // Should print 9
        Console.WriteLine(Reducer.SumDigProd(9, 8));  // Should print 7
        Console.WriteLine(Reducer.SumDigProd(16, 28));  // Should print 6
        Console.WriteLine(Reducer.SumDigProd(111111111));
        Console.WriteLine(Reducer.SumDigProd(1, 2, 3, 4, 5, 6));
        Console.WriteLine(Reducer.SumDigProd(8, 16, 89, 3));
        Console.WriteLine(Reducer.SumDigProd(26, 497, 62, 841));
        Console.WriteLine(Reducer.SumDigProd(17737, 98723, 2));
        Console.WriteLine(Reducer.SumDigProd(123, -99));
        Console.WriteLine(Reducer.SumDigProd(167, 167, 167, 167, 167,
        3));
        Console.WriteLine(Reducer.SumDigProd(98526, 54, 863, 156489,
        45, 6156));
    }
}
