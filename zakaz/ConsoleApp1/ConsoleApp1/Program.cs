using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zakaz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Warehouse warehouse = new Warehouse();
            warehouse.PrintInventory();
            int[] order = new int[5];
            while (true)
            {
                int partNumber = warehouse.GetPartNumber();
                if (partNumber == 0)
                {
                    break;
                }
                int quantity = warehouse.GetQuantity();
                order[partNumber - 1] += quantity;
                Console.WriteLine("(Для завершения заказа введите 0)");
            }

            bool success = warehouse.ProcessOrder(order);

            if (success)
            {
                warehouse.UpdateInventory(order);
                Console.WriteLine("\nОстатки запчастей:");
                warehouse.PrintInventory();
            }
            else
            {
                Console.WriteLine("\nЗаказ не выполнен. Остатки не изменены.");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
