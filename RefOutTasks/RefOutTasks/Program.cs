namespace RefOutTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -5, 10, -15, 20, -25 };

            Console.WriteLine("Original Array:");
            PrintArray(numbers);

            ConvertNegativesToPositives(ref numbers);

            Console.WriteLine("Modified Array (Negative Elements Converted to Positives):");
            PrintArray(numbers);
        }

        static void ConvertNegativesToPositives(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = -array[i];
                }
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.WriteLine(number + " ");
            }
        }
    }
}