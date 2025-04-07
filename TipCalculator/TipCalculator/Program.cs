namespace TipCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму счета (руб): ");
            decimal billAmount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Введите процент чаевых: ");
            decimal tipsPercent = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Введите кол-во людей: ");
            int numOfPeople = Convert.ToInt32(Console.ReadLine());

            // Чаевые в общем 
            decimal tips = Math.Round((tipsPercent / 100) * billAmount, 2);
            Console.WriteLine($"Чаевые: {tips} руб");

            // Счет на человека с учетом чаевых
            decimal billPerPerson = Math.Round((tips + billAmount) / numOfPeople, 2);
            Console.WriteLine($"Счет на человека: {billPerPerson} руб");
        }
    }
}
