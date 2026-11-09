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
            return 0;
        }
    }
}
