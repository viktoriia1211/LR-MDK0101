using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Warehouse
    {
        private string[] partNames = { "масляный фильтр", "тормозные колодки", "свечи зажигания", "ремень ГРМ", "антифриз" };
        private decimal[] partPrices = { 350m, 1200m, 850m, 1800m, 750m };
        private int[] partQuantities = { 20, 15, 24, 8, 12 };
        public void PrintInventory()
        {
            Console.WriteLine("Склад запчастей:");
            for (int i = 0; i < partNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {partNames[i]} — {partPrices[i]} руб., {partQuantities[i]} шт.");
            }
        }
    }
}
