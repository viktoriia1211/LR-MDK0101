using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    public class Accessories : Product
    {
        public override int FindDiscount()
        {
            if (Amount_ >= 20 && Amount_ <= 150)
            {
                return 10;
            }
            else if (Amount_ >= 150 && Amount_ <= 300)
            {
                return 30;
            }
            else if (Amount_ > 300)
            {
                return 50;
            }
            return 0;
        }
    }
}
