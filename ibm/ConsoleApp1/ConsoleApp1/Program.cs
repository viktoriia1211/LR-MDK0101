using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расчет ИМТ");
            double height = Class1.GetHeight();
            double weight = Class1.GetWeight();
            double bmi = Class1.CalculateBMI(height, weight);
            string category = Class1.GetCategory(bmi);
            string recommendation = Class1.GetRecommendation(category);
            Class1.PrintResults(bmi, category, recommendation);
            Console.ReadKey() ;
        }
    }
}
