using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    public class CsvWriter
    {
        public static void SaveToFile(List<Product> products, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Type;Name;Price;Amount");

                foreach (Product item in products)
                {
                    string type = item is Accessories ? "Accessories" : "Perfumery";
                    writer.WriteLine($"{type};{item.GetName()};{item.GetPrice()};{item.GetAmount()}");
                }
            }
            Console.WriteLine("Данные сохранены в файл: " + filePath);
        }
    }
}
