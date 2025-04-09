namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Коллекция словарь:");
            Dictionary<string, int> ages = new()
            {
                { "Bob", 20 },
                { "Paul", 22 },
                { "Sonya", 23 }
            };
            foreach (var pair in ages)
            {
                Console.WriteLine($"Имя: {pair.Key}, Возраст: {pair.Value}");
            }
            Console.WriteLine();
            // Удаления всех пар
            ages.Clear();
            foreach (var pair in ages)
            {
                Console.WriteLine($"Имя: {pair.Key}, Возраст: {pair.Value}");
            }
            // Добавление пар
            ages.Add("Hi", 2);
            ages.Add("Bye", 4);
            ages.Add("Goodbye", 6);
            ages.Add("Goodhi", 6);
            ages.Add("Hell", 6);
            foreach (var pair in ages)
            {
                Console.WriteLine($"Имя: {pair.Key}, Возраст: {pair.Value}");
            }

            //Удаление происходит по ключу пары
            ages.Remove("Bye");

            Console.WriteLine("\nПребор только ключей");
            foreach (var item in ages.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nПребор только значений");
            foreach (var item in ages.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
