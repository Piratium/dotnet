namespace convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Неявное преобразование типа
            int i1 = 2;
            double d1 = i1;
            // Явное преобразование типа
            double d2 = 123.556;
            int i2 = Convert.ToInt32(d2);
            int j2 = (int)d2;
            Console.WriteLine(j2);
            // Преобразование методом Parse
            string myString = "982.242";
            Console.WriteLine("string: " + myString);
            double myDouble = double.Parse(myString);
            Console.WriteLine("double: " + myDouble);
            // Преобразование с использованием метода TryParse
            string invalidIntString = "123.456";
            int parseResult;

            bool isSuccess = int.TryParse(invalidIntString, out parseResult);
            Console.WriteLine($"Попытка преобразования строки в число с использованием TryParse: {isSuccess}, результат: {parseResult}");
            // Если попытка неудачная (isSuccess: False), то во второй параметр будет присвоено 0
        }
    }
}
