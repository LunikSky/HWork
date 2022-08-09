using System;

public class Test5Easy
{
	public void DefiningLargerNumber()
	{
        Console.WriteLine("Введите число: a");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите число: b");
        double b = Convert.ToDouble(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine($"Число а:{a}больше числа b{b}");
        }
        else
        {
            Console.WriteLine($"Число b:{b}больше числа a{a}");
        }
    }
}
