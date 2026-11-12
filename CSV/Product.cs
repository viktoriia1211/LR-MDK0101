using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    public class Product
    {
        protected string Name_;
        protected double Price_;
        protected int Amount_;

        public void SetName(string name) { Name_ = name; }
        public void SetPrice(double price) { Price_ = price; }
        public void SetAmount(int amount) { Amount_ = amount; }

        public string GetName() { return Name_; }
        public double GetPrice() { return Price_; }
        public int GetAmount() { return Amount_; }

        public virtual int FindDiscount()
        {
            return 0;
        }
    }
}
