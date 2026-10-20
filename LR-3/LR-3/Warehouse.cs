using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3
{
    public class Warehouse
    {
        public List<SparePart> Parts { get; private set; }

        public Warehouse()
        {
            Parts = new List<SparePart>
            {
                new SparePart(PartType.OilFilter, "масляный фильтр", 350, 20),
                new SparePart(PartType.BrakePads, "тормозные колодки", 1200, 15),
                new SparePart(PartType.SparkPlugs, "свечи зажигания", 850, 24),
                new SparePart(PartType.TimingBelt, "ремень ГРМ", 1800, 8),
                new SparePart(PartType.Antifreeze, "антифриз", 750, 12)
            };
        }
        public void PrintInventory()
        {
            Console.WriteLine("Склад запчастей:");
            foreach (var part in Parts)
            {
                Console.WriteLine($"{(int)part.Type}. {part.Name} — {part.Price} руб., {part.Quantity} шт.");
            }
        }
        public bool ProcessOrder(Dictionary<PartType, int> order)
        {
            foreach (var item in order)
            {
                var part = Parts.Find(p => p.Type == item.Key);
                if (part.Quantity < item.Value)
                {
                    Console.WriteLine($"Ошибка: не хватает '{part.Name}'. На складе: {part.Quantity}, нужно: {item.Value}");
                    return false; // Заказ не принят
                }
            }

            int totalCost = 0;
            foreach (var item in order)
            {
                var part = Parts.Find(p => p.Type == item.Key);
                part.Quantity -= item.Value; // Списание
                totalCost += part.Price * item.Value;
            }

            Console.WriteLine($"Стоимость заказа: {totalCost} руб.");
            return true; // Заказ принят
        }
    }
}
