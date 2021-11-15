﻿using System;

namespace Pr9.Models
{
    class Dairy_products : Product
    {
        private int _shelfLife;

        public Dairy_products(string name, double price = 0.0, double weight = 0.0, int shelfLife = 0) : base(name, price,
            weight)
        {
            _shelfLife = shelfLife;
        }

        public int ShelfLife { get => _shelfLife; set => _shelfLife = value; }

        public override bool Equals(object obj)
        {
            return obj is Dairy_products products &&
                   _shelfLife == products._shelfLife;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_shelfLife);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override double ChangePrice(int procent)
        {
            if (_shelfLife > 7)
                return base.ChangePrice(procent) * 15 / 100.0;

            return base.ChangePrice(procent) * 5 / 100.0;
        }
    }
}
