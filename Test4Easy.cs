using System;

public class Test4Easy
{
	public void TransferPoundsToKilograms()
	{
		Console.WriteLine("Введите массу в фунтах: ");
		double a = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine($"Масса в килограммах равна: {a * 0,453}");
	}

	public void TransferKilogramssToPounts()
	{
		Console.WriteLine("Введите массу в килограммах: ");
		double b = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine($"Масса в фунтах равна: {b / 0,453}");
	}
}