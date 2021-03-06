﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarket.Models.ProductModels
{
    public class ProductRatingTableViewModel : Product
    {
        public bool PositionRight { get; set; }
        public char Position { get => PositionRight ? 'r' : 'l'; }

        public ProductRatingTableViewModel(Product product, bool positionRight = false)
        {
            ID = product.ID;
            Name = product.Name;
            PositionRight = positionRight;
        }

        public float GetStarsValue(IMainRepository repository)
        {
            return this.GetRate(repository);
        }
    }
}
