using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    public class CsvReader
    {
        public static List<Product> LoadFromFile(string filePath)
        {
            List<Product> products = new List<Product>();
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден: " + filePath);
                return products;
            }
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isFirstLine = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }
                    string[] parts = line.Split(';');
                    if (parts.Length == 4)
                    {
                        string type = parts[0];
                        string name = parts[1];
                        double price = double.Parse(parts[2]);
                        int amount = int.Parse(parts[3]);
                        Product item;
                        if (type == "Accessories")
                            item = new Accessories();
                        else
                            item = new Perfumery();
                        item.SetName(name);
                        item.SetPrice(price);
                        item.SetAmount(amount);
                        products.Add(item);
                    }
                }
            }
            return products;
        }
    }
}
