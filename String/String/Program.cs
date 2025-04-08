namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello, ";
            string world = "World!";
            string combined = string.Concat(hello, world);
            Console.WriteLine(combined);

            // Пример использования метода Contains
            bool containsWorld = combined.Contains("World");
            Console.WriteLine($"Содержит ли строка значение 'world': {containsWorld}");

            // Пример использования индексации символа/подстроки методом IndexOf, LastIndexOf
            int indexOfW = combined.LastIndexOf("o");
            Console.WriteLine(indexOfW);

            // Метод Substring возвращает подстроку начиная с указанного индекса символа
            // строка.Substring(индекс,длина)
            string sub = combined.Substring(7, 5);
            Console.WriteLine(sub);

            // Пример использования Replace
            string replaced = combined.Replace("World", "C#");
            Console.WriteLine(replaced);

            var parts = "one,two,three   four".Split(
                new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries
            );
            Console.WriteLine(parts.Length);

            // Изменение регистра строки
            string lowerCase = combined.ToLower();
            string upperCase = combined.ToUpper();
            Console.WriteLine($"Нижний регистр: {lowerCase}\nВерхний регистр: {upperCase}");

            // Удаление пробелов в конце и начале строки (можно только с одной стороны)
            string trimString = "   Hello     WRLD!       ".Trim();
            Console.WriteLine(trimString);

            // Получение длины строки
            int length = combined.Length;
            Console.WriteLine(length);

            // Сравнение строк с учетом последнего параметра
            bool areEqual = string.Equals("Hello", "hello", StringComparison.OrdinalIgnoreCase); // Игнорирует регистр
            Console.WriteLine(areEqual);
        }
    }
}
