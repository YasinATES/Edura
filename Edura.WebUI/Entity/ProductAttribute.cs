using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Entity
{
    public class ProductAttribute
    {
        public int ProductAttributeId { get; set; }
        public String Attribute { get; set; }
        public String Value { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
