using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    public class Perfumery : Product
    {
        public override int FindDiscount()
        {
            if (Amount_ >= 5 && Amount_ <= 10)
            {
                return 15;
            }
            else if (Amount_ > 10)
            {
                return 25;
            }
            return 0;
        }
    }
}
