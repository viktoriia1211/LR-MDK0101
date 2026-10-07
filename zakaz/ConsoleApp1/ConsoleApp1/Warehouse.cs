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
        public int GetPartNumber()
        {
            int number;
            while (true)
            {
                Console.Write("Введите номер запчасти (0 - конец заказа): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    if (number >= 0 && number <= 5)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: номер должен быть от 0 до 5.");
                    }
                }
                else
                {
                     Console.WriteLine("Ошибка: введено не число.");
                }
            }

        }
        public int GetQuantity()
        {
            int quantity;
            while (true)
            {
                Console.Write("Введите количество: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out quantity))
                {
                    if (quantity > 0)
                    {
                        return quantity;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: количество должно быть больше 0.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введено не число.");
                }
            }
        }
        public bool ProcessOrder(int[] order)
        { 
            for (int i = 0; i < order.Length; i++)
            {
                if (order[i] > partQuantities[i])
                {
                    Console.WriteLine($"Ошибка: запчасти \"{partNames[i]}\" не хватает. На складе: {partQuantities[i]}, заказано: {order[i]}");
                    return false; 
                }
            }

            decimal totalCost = 0;
            for (int i = 0; i < order.Length; i++)
            {
                totalCost += order[i] * partPrices[i];
            }

            Console.WriteLine($"Стоимость заказа: {totalCost} руб.");
            return true;
        }
        public void UpdateInventory(int[] order)
        {
            for (int i = 0; i < order.Length; i++)
            {
                partQuantities[i] -= order[i];
            }
        }
    
    }

}
