namespace QuestionnaireOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пройди пару загадок\n");

            // Первая загадка
            Console.Write("Висит груша - нельзя скушать: ");
            string answer = Console.ReadLine();
            Console.WriteLine((answer.ToLower().Trim() == "груша") ? "Верно!" : "Неверно:(");

            // Вторая загадка
            Console.Write("Весной и летом одним цветом: ");
            answer = Console.ReadLine();
            if (answer.Contains("е")) answer = answer.Replace("е", "ё");
            Console.WriteLine((answer.ToLower().Trim() == "ёлка") ? "Верно!" : "Неверно:(");
        }
    }
}
