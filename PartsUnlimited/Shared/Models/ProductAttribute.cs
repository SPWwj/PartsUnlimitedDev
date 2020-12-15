using System;
using System.Collections.Generic;

#nullable disable

namespace PartsUnlimited.Client.Models
{
    public partial class ProductAttribute
    {
        public ProductAttribute()
        {
            AttributeSections = new HashSet<AttributeSection>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<AttributeSection> AttributeSections { get; set; }
    }
}
