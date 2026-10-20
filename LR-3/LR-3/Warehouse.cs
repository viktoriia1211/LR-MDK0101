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
    }
}
