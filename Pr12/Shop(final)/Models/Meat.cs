using System;
using Pr9.Enums;
using Type = Pr9.Enums.Type;

namespace Pr9.Models
{
    class Meat : Product
    {
        private Category Category { get; set; }
        private Type Type { get; set; }

        public Meat(string name = "", double price = 0.0, double weight = 0.0,
            Category category = Category.Higher_sort, Type type = Type.Chicken) : base(name, price, weight)
        {
            Category = category;
            Type = type;
        }

        public override bool Equals(object obj)
        {
            return obj is Meat meat &&
                   Name == meat.Name &&
                   Price == meat.Price &&
                   Weight == meat.Weight;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price, Weight);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override double ChangePrice(int procent = 1)
        {
            if (Category == Category.Higher_sort)
                return base.ChangePrice(procent) * 30 / 100.0;
            else if (Category == Category.First_sort)
                return base.ChangePrice(procent) * 20 / 100.0;
            
            return base.ChangePrice(procent) * 10 / 100.0;
        }
    }
}
