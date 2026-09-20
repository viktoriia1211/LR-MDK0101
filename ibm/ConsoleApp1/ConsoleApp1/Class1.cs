using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    public static class Class1
    {
        public static double GetHeight()
        {
            while (true)
            {
                Console.WriteLine("Введите рост (см):");
                if (double.TryParse(Console.ReadLine(), out double height) && height > 0)
                    return height;
                Console.WriteLine("Ошибка! Введите положительное число");
            }
        }
    }
}
