namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = [ 1, 2, 3, 4, 5 ];
            HashSet<int> set2 = [ 4, 5, 6, 7, 8 ];
            set2.Add(3);
            set1.Remove(2);
            Console.WriteLine("Множество первое:");
            foreach (int item in set1)
                Console.Write(item + " ");
            Console.WriteLine("\n\nМножество второе:");
            foreach (int item in set2)
                Console.Write(item + " ");


            Console.WriteLine("\n\nПересечение множеств:");
            HashSet<int> resultSet = new(set1.Intersect(set2));
            foreach (int item in resultSet)
                Console.Write(item + " ");

            Console.WriteLine("\n\nОбъединение множеств:");
            resultSet = new(set1.Union(set2));   
            foreach(int item in resultSet)
            {
                Console.Write(item + " ");
            }
        }
    }
}
