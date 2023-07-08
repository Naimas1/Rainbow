using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow
{
    class Programr
    {
        static void Main()
        {
            int[] numbers = { -2, 5, -10, 0, -10, -3, 8, 1, -2, -3 };

            Action<int[]> displayUniqueNegativeNumbers = arr =>
            {
                var uniqueNegativeNumbers = arr.Where(num => num < 0).Distinct();
                foreach (int num in uniqueNegativeNumbers)
                {
                    Console.WriteLine(num);
                }
            };

            displayUniqueNegativeNumbers(numbers);
        }
    }
}
