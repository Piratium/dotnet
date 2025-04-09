namespace Cortege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCortege = (1, 2, "str", new[] { 3, 2, 3 });   
            Console.WriteLine(myCortege);
            Console.WriteLine(myCortege.Item3);
            Console.WriteLine(String.Join(", ", myCortege.Item4));

            (int x, int y, string, bool bruh) anotherCortege = (2, 5, "word", false);
            Console.WriteLine(anotherCortege.Item2);
            Console.WriteLine(anotherCortege.Item3);
            Console.WriteLine(anotherCortege.bruh);
            
            Tuple<int, int, int, int, int> thirdCortege = new(1, 2, 3, 4, 5);
        }
    }
}
