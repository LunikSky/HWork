using System;

public class Test1Easy
{
	public void CalculatingAreaTriangle()
	{
        Console.WriteLine("Введите длинну катета: a");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите длинну катета: b");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Площадь прямоугольного треугольника равна: {(a * b) / 2}");
    }
}

