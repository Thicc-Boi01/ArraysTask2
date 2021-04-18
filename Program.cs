using System;

namespace ArraysTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };
            int sum = 0;
            Array.ForEach(numbers, delegate (int i) { sum += i; });
            Console.WriteLine("The sum of the Array is: " + sum);
        }
    }
}
