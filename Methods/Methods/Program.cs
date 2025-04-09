namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void A() { Console.WriteLine("Hi"); }
            void B(string name) { Console.WriteLine($"My name is {name}"); }
            double C() { return Math.Pow(10, 10); }
            double D(double x, int y) { return x + y; }
            A();
            B("Paul");
            Console.WriteLine(C());
            Console.WriteLine(D(5, 2));
            Console.WriteLine(D(C(),101010101));
        }
    }
}
