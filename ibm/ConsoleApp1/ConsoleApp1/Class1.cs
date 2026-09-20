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
        public static double GetWeight()
        {
            while (true)
            {
                Console.WriteLine("Введите вес (кг):");
                if (double.TryParse(Console.ReadLine(), out double weight) && weight > 0)
                    return weight;
                Console.WriteLine("Ошибка! Введите положительное число");
            }
        }
        public static double CalculateBMI(double heightCm, double weightKg)
        {
            double heightM = heightCm / 100.0;
            return weightKg / (heightM * heightM);
        }

    }
}
