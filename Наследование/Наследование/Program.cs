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
            oboem.SetName("Овсянка");
            oboem.SetPrice(300);
            oboem.SetAmount(7);

            Perfumery flora = new Perfumery();
            flora.SetName("Чай 'Флора'");
            flora.SetPrice(480);
            flora.SetAmount(27);

            Perfumery luxury = new Perfumery();
            luxury.SetName("Чай 'Люкс'");
            luxury.SetPrice(890);
            luxury.SetAmount(70);
        }
    }
}
