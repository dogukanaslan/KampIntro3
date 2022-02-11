using System;

namespace Switch1
{
	class Program
	{
		static void Main(string[] args)
		{
			switch (DateTime.Now.DayOfWeek)
			{
				case DayOfWeek.Monday:
				case DayOfWeek.Tuesday:
				case DayOfWeek.Wednesday:
				case DayOfWeek.Thursday:
				case DayOfWeek.Friday:
					Console.WriteLine("Haftaiçindeyiz çalışmaya devam...");
					break;
				case DayOfWeek.Saturday:
				case DayOfWeek.Sunday:
					Console.WriteLine("Dinlen şimdi pazartesi iş bizi bekler...");
					break;
			}


			switch (DateTime.Now.DayOfWeek)
            {
				case DayOfWeek.Saturday:
				case DayOfWeek.Sunday:
                    Console.WriteLine("Dinlen Şimdi Pazartesi İş Bizi Bekler");
					break;
				default:
                    Console.WriteLine("Haftaiçindeyiz çalışmaya devam");
					break;
            }
				
		}
	}
}