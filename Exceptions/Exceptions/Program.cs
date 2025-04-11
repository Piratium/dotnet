namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            try
            {
                Console.WriteLine(array[12]);
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Какая-то ошибка: " + ex.Message);
            }
        }
    }
}
