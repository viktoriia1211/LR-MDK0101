using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accessories ring = new Accessories();
            ring.SetName("Кольцо");
            ring.SetPrice(1300);
            ring.SetAmount(25);

            Accessories pendant = new Accessories();
            pendant.SetName("Подвеска");
            pendant.SetPrice(1800);
            pendant.SetAmount(35);

            Accessories earrings = new Accessories();
            earrings.SetName("Серьги");
            earrings.SetPrice(4000);
            earrings.SetAmount(55);

            Perfumery oboem = new Perfumery();
            oboem.SetName("Одеколон");
            oboem.SetPrice(300);
            oboem.SetAmount(7);

            Perfumery flora = new Perfumery();
            flora.SetName("Парфюм флора");
            flora.SetPrice(480);
            flora.SetAmount(27);

            Perfumery luxury = new Perfumery();
            luxury.SetName("Парфюм Люкс");
            luxury.SetPrice(890);
            luxury.SetAmount(70);
            Console.WriteLine("Название        | Цена     | Кол-во   | Стоимость    | Скидка     | Итого     ");
            Console.WriteLine(" ");
            PrintInfo(ring);
            PrintInfo(pendant);
            PrintInfo(earrings);
            PrintInfo(oboem);
            PrintInfo(flora);
            PrintInfo(luxury);
            Console.ReadKey();

        }
        static void PrintInfo(Product item)
        {
            double totalCost = item.Price_ * item.Amount_;
            int discountPercent = item.FindDiscount();
            double finalCost = totalCost - (totalCost * discountPercent / 100.0);
            string name = item.Name_.PadRight(15);
            string price = item.Price_.ToString().PadRight(8);
            string amount = item.Amount_.ToString().PadRight(8);
            string cost = totalCost.ToString().PadRight(12);
            string discount = (discountPercent + "%").PadRight(10);
            string final = finalCost.ToString().PadRight(10);

            Console.WriteLine($"{name} | {price} | {amount} | {cost} | {discount} | {final}");
        }

    }
}
