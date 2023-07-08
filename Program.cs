using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow
{
    class Programw
    {
        static void Main()
        {
            int[] numbers = { -2, 5, -10, 0, 15, -3, 8, 1 };

            Func<int[], int> countPositiveNumbers = arr =>
            {
                int count = 0;
                foreach (int num in arr)
                {
                    if (num > 0)
                        count++;
                }
                return count;
            };

            int result = countPositiveNumbers(numbers);
            Console.WriteLine($"Кількість позитивних чисел: {result}");
        }
    }
}
