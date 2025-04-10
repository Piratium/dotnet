namespace DateTime
{
    using System;
    using Microsoft.VisualBasic;

    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;
            DateTime specificDate = new(2025, 2, 3);
            Console.WriteLine($"Дата и время: {now}");
            Console.WriteLine($"Дата: {today}");
            Console.WriteLine($"Специфическая дата: {specificDate}");
            // Манипуляции с датами
            DateTime tomorrow = now.AddDays(1);
            DateTime nextMonth = now.AddMonths(1);
            DateTime nextYear = now.AddYears(1);
            DateTime oneHourLater = now.AddHours(1);
            Console.WriteLine($"Следующий день: {tomorrow}");
            Console.WriteLine($"Следующий месяц: {nextMonth}");
            Console.WriteLine($"Следующий год: {nextYear}");
            Console.WriteLine($"Через один час: {oneHourLater}");
            // Использование TimeSpan
            TimeSpan tenDays = TimeSpan.FromDays(10);
            DateTime tenDaysFromNow = now.Add(tenDays);
            Console.WriteLine($"Через десять дней будет: {tenDaysFromNow}");
            // Форматирование даты и времени
            string formattedDate = now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine($"Отформатированная дата и время: {formattedDate}");
            // Работа с часовыми поясами
            TimeZoneInfo localeZone = TimeZoneInfo.Local;
            DateTime utcNow = DateTime.UtcNow;
            DateTime localeTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow,localeZone);
            Console.WriteLine($"Локальное время: {localeTime}");
            Console.WriteLine($"UTC время: {utcNow}");
            Console.WriteLine($"Локальная зона: {localeZone}");
        }
    }
}
