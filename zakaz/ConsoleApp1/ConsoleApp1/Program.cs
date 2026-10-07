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
            int testNumber = warehouse.GetPartNumber();
            Console.WriteLine($"Вы ввели номер: {testNumber}");
            int testQuantity = warehouse.GetQuantity();
            Console.WriteLine($"Вы ввели количество: {testQuantity}");

            Console.ReadKey();
        }
    }
}
