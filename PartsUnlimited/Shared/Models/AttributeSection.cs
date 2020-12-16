using System;
using System.Collections.Generic;

#nullable disable

namespace PartsUnlimited.Shared.Models
{
    public partial class AttributeSection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ProductAttributeId { get; set; }
        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductAttribute ProductAttribute { get; set; }
    }
}
