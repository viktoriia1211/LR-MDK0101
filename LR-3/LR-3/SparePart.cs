using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3
{
    public class SparePart
    {
        public PartType Type { get; set; } // Тип запчасти
        public string Name { get; set; }   // Название
        public int Price { get; set; }     // Цена
        public int Quantity { get; set; }  // Количество на складе

      
    }
}
