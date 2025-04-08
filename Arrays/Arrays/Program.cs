namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Одномерный массив:");
            int[] myArray = new int[] { 1, 2, 3, 4 };
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();

            int[,] multiArray = new int[2,3] { { 2, 3, 1 }, { 1, 2, 3 } };
            Console.WriteLine("\nДвумерный массив:");
            for (int i = 0; i < multiArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiArray.GetLength(1); j++)
                {
                    Console.Write(multiArray[i,j] + " ");
                }
                Console.WriteLine();
            }

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[3] { 14, 23, 51 };
            jaggedArray[1] = new int[2] { 81, 34 };
            jaggedArray[2] = new int[] { 17, 11, 94, 21 };
            Console.WriteLine("\nЗубчатый массив:");
            foreach (int[] arr in jaggedArray)
            {
                foreach (int element in arr)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
