using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "products.csv";

            Console.WriteLine("Загрузка товаров из файла...");
            List<Product> products = CsvReader.LoadFromFile(filePath);
            if (products.Count == 0)
            {
                Console.WriteLine("Список пуст. Проверьте файл.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Название        | Цена     | Кол-во   | Стоимость    | Скидка     | Итого     ");
            Console.WriteLine(" ");
            foreach (Product item in products)
            {
                PrintInfo(item);
            }

            Console.ReadKey();
        }
        static void PrintInfo(Product item)
        {
            double totalCost = item.GetPrice() * item.GetAmount();
            int discountPercent = item.FindDiscount();
            double finalCost = totalCost - (totalCost * discountPercent / 100.0);

            string name = item.GetName().PadRight(15);
            string price = item.GetPrice().ToString().PadRight(8);
            string amount = item.GetAmount().ToString().PadRight(8);
            string cost = totalCost.ToString().PadRight(12);
            string discount = (discountPercent + "%").PadRight(10);
            string final = finalCost.ToString().PadRight(10);
            Console.WriteLine($"{name} | {price} | {amount} | {cost} | {discount} | {final}");
        }
    }
}
