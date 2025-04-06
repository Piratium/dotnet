namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 5;
            Console.WriteLine(Math.Max(a, b));
            Console.WriteLine($"Math.Floor(2.7) - {Math.Floor(2.7)}");
            Console.WriteLine($"Math.Ceiling(2.3) - {Math.Ceiling(2.3)}");
            Console.WriteLine($"Math.Round(2.5) - {Math.Round(2.5)}");

            double angle = Math.Sin(Math.PI / 2);
            Console.WriteLine(angle);

            Console.WriteLine($"2 в степени 3 - {Math.Pow(2, 3)}");
            Console.WriteLine($"Квадратный корень из 16 - {Math.Sqrt(16)}");
        }
    }
}
