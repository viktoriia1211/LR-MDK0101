using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    public class Product
    {
        public string Name_;
        public double Price_;
        public int Amount_;

        public void SetName(string name) { Name_ = name; }
        public void SetPrice(double price) { Price_ = price; }
        public void SetAmount(int amount) { Amount_ = amount; }

        public virtual int FindDiscount()
        {
            return 0;
        }
    }
}
