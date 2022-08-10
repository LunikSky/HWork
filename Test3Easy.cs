using System;

public class Test3Easy
{
	public static void Main()
	{
		WriteDayWeek(Weekday.Friday);
		WriteDayWeek(Weekday.Tuesday);
		WriteDayWeek(Weekday.Sunday);
	}

	public static void WriteDayWeek(Weekday wd)
	{
		switch (wd)
		{
			case Weekday.Monday:
				Console.WriteLine("Today is Monday");
				break;
			case Weekday.Tuesday:
				Console.WriteLine("Today is Tuesday");
				break;
			case Weekday.Wednesday:
				Console.WriteLine("Today is Wednesday");
				break;
			case Weekday.Thursday:
				Console.WriteLine("Today is Thursday");
				break;
			case Weekday.Friday:
				Console.WriteLine("Today is Friday");
				break;
			case Weekday.Saturday:
				Console.WriteLine("Today is Saturday");
				break;
			case Weekday.Sunday:
				Console.WriteLine("Today is Sunday");
				break;
			default:
				Console.WriteLine("Strange week");
				break;
		}
	}
}

public enum Weekday
{
	Monday,
	Tuesday,
	Wednesday,
	Thursday,
	Friday,
	Saturday,
	Sunday
}