namespace BranchingLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 5;

            if (a > b)
            {
                Console.WriteLine("A больше B");
            }
            else if (a < b)
            {
                Console.WriteLine("A меньше B");
            }
            else
            {
                Console.WriteLine("A и B равны");
            }

            switch (a)
            {
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("a = 2");
                    break;
                case 3:
                    Console.WriteLine("a = 3");
                    break;
                default:
                    Console.WriteLine("Число не прошло критерии.");
                    break;
            }

            // Тернарный оператор
            int myNumber = 8;
            Console.WriteLine(myNumber > 10 ? "Число больше 10" : "Число меньше 10");

            // Пример использования switch выражений
            int temp = 15;
            string resultValueTemp = temp switch
            {
                1 => "Один",
                2 => "Два",
                3 => "Три",
                // _ обозначает все остальные случаи
                _ => "Число неопределено"
            };
            Console.WriteLine(resultValueTemp);
        }
    }
}
