using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();

            warehouse.PrintInventory();

            Dictionary<PartType, int> order = new Dictionary<PartType, int>();

            while (true)
            {
                Console.Write("Введите номер запчасти (0 — конец заказа): ");

                if (!int.TryParse(Console.ReadLine(), out int partNumber))
                {
                    Console.WriteLine("Ошибка: введено не число.");
                    continue;
                }

                if (partNumber == 0) break; 

                if (partNumber < 1 || partNumber > 5)
                {
                    Console.WriteLine("Ошибка: номер запчасти должен быть от 1 до 5.");
                    continue;
                }

                PartType selectedPart = (PartType)partNumber;

                Console.Write("Введите количество: ");
                if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
                {
                    Console.WriteLine("Ошибка: количество должно быть больше 0.");
                    continue;
                }
                if (order.ContainsKey(selectedPart))
                    order[selectedPart] += quantity;
                else
                    order[selectedPart] = quantity;
            }
            if (order.Count > 0)
            {
                warehouse.ProcessOrder(order);
            }

            Console.WriteLine("\nОстатки запчастей:");
            warehouse.PrintInventory(); 

            Console.ReadKey(); 
        }
    }
}
