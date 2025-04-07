namespace TipCalculator
{
    internal class Program
    {
        static void ParseResult(bool isParse)
        {
            if (!isParse)
            {
                Console.WriteLine("Данные введены некорректно!");
                Environment.Exit(1);
            }
        } 
        static void Main(string[] args)
        {
            Console.Write("Введите сумму счета (руб): ");
            decimal billAmount;
            bool IsBillAmountParse = decimal.TryParse(Console.ReadLine(), out billAmount);
            ParseResult(IsBillAmountParse);

            Console.Write("Введите процент чаевых: ");
            decimal tipsPercent;
            bool IsTipsPercentParse = decimal.TryParse(Console.ReadLine(), out tipsPercent);
            ParseResult(IsTipsPercentParse);

            Console.Write("Введите кол-во людей: ");
            int numOfPeople;
            bool IsNumOfPeopleParse = int.TryParse(Console.ReadLine(), out numOfPeople);
            ParseResult(IsNumOfPeopleParse);

            // Чаевые в общем 
            decimal tips = Math.Round((tipsPercent / 100) * billAmount, 2);
            Console.WriteLine($"Чаевые: {tips} руб");

            // Счет на человека с учетом чаевых
            decimal billPerPerson = Math.Round((tips + billAmount) / numOfPeople, 2);
            Console.WriteLine($"Счет на человека: {billPerPerson} руб");
        }
    }
}
