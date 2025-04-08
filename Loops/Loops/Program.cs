namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Цикл while");
            int iWhile = 0;
            while (iWhile < 5)
            {
                Console.WriteLine($"Значение i: {iWhile}");
                iWhile++;
            }

            Console.WriteLine("\nЦикл for");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Значение i: {i}");
            }

            // foreach только для чтения
            Console.WriteLine("\nЦикл foreach");
            string helloWrld = "Hello, World!";
            foreach (char symbol in helloWrld)
            {
                Console.WriteLine(symbol);
            }
        }
    }
}