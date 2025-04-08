namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Коллекция лист:");
            List<int> list = new() { 1, 2, 3, 4, 5, 6, 7 };
            list.Add(78);
            //list.Remove(2);
            //list.RemoveAt(list.Count - 1);
            string myList = string.Join(", ", list);
            Console.WriteLine(myList);

        }
    }
}
