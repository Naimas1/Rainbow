using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow
{
    class Programq
    {
        static void Main()
        {
            int[] numbers = { 7, 14, 21, 28, 35, 42, 49, 56, 63, 70 };

            Func<int[], int> countMultiplesOfSeven = arr => arr.Count(num => num % 7 == 0);

            int result = countMultiplesOfSeven(numbers);
            Console.WriteLine($"Кількість чисел, кратних семи: {result}");
        }
    }
}
