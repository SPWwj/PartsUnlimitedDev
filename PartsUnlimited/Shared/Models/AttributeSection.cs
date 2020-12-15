using System;
using System.Collections.Generic;

#nullable disable

namespace PartsUnlimited.Client.Models
{
    public partial class AttributeSection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ProductAttributeId { get; set; }

        public virtual ProductAttribute ProductAttribute { get; set; }
    }
}
