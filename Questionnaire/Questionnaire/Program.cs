namespace Questionnaire
{
    internal class Program
    {
        static void ParseResult(bool isParse)
        {
            if (!isParse)
            {
                Console.WriteLine("\nДанные введены некорректно.\nТы и близко не Халк:(");
                Environment.Exit(1);
            }
        }
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("Пройди небольшой опрос.\nПосле прохождения опроса узнаешь на сколько ты халк.\nВсе ответы нужно вводить исключительно в числах, настоящий Халк отвечает только циферками.");

            Console.Write("\nСколько мышц у Халка: ");
            int muscles;
            bool isMusculesParse = int.TryParse(Console.ReadLine(), out muscles);
            ParseResult(isMusculesParse);
            if (muscles >= 1000) score += 250;

            Console.Write("\nСколько силы у Халка: ");
            int power;
            bool isPowerParse = int.TryParse(Console.ReadLine(), out power);
            ParseResult(isPowerParse);
            if (power >= 1000) score += 250;

            Console.Write("\nСколько кондиционеров у Халка: ");
            int conditioners;
            bool isConditionersParse = int.TryParse(Console.ReadLine(),out conditioners);
            ParseResult(isConditionersParse);
            if (conditioners <= 2) score += 250;

            Console.Write("\nСколько котлет у Халка: ");
            int cutlets;
            bool isCutletsParse = int.TryParse(Console.ReadLine(), out cutlets);
            ParseResult(isCutletsParse);
            if (cutlets >= 10) score += 250;

            if (score < 500) Console.WriteLine("\nТы Халк на полшишечки, не расстраивайся.");
                else if (score >= 500 && score <= 750) Console.WriteLine("\nОоо! Ты почти Халк.");
                else Console.WriteLine("\nНа самом деле Халк - я, но теперь начал в этом сомневаться...");
        }
    }
}
