﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PartsUnlimited.Shared.Models
{
    public partial class Product
    {
        public Product()
        {
            AttributeSections = new HashSet<AttributeSection>();
            ProductAttributes = new HashSet<ProductAttribute>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal? Price { get; set; }
        public decimal? PromoPrice { get; set; }
        public string Image { get; set; }

        public virtual ICollection<AttributeSection> AttributeSections { get; set; }
        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }
    }
}
