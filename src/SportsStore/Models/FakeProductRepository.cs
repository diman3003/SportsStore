﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product> {
            new Product { Name = "Football", Price = 250 },
            new Product { Name = "Surf board", Price = 1790 },
            new Product { Name = "Running shoes", Price = 950, Description = "Boots" }
        };
    }
}
