namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsEven(int x)
            {
                return x % 2 == 0;
            }

            int[] myNums = [1,2,3,4,5,6,7,8,9,10,12,11,14,13];

            int[] filterNums(int[] nums, MyMethodDelegate operation)
            {
                int countEven = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (operation(nums[i]))
                        countEven++;
                }
                int[] filteredNums = new int[countEven];
                int position = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (operation(nums[i]))
                    {
                        filteredNums[position] = nums[i];
                        position++;
                    }
                }
                return filteredNums;
            }

            int[] filteredNums = filterNums(myNums, IsEven);
            Console.WriteLine($"Четные числа: { String.Join(", ", filteredNums)}");
        }
        delegate bool MyMethodDelegate(int value);
    }
}
