using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    public class Accessories : Product
    {
        public override int FindDiscount()
        {
            if (Amount_ >= 20 && Amount_ <= 150) return 10;
            if (Amount_ >= 150 && Amount_ <= 300) return 30;
            if (Amount_ > 300) return 50;
            return 0;
        }
    }
}
