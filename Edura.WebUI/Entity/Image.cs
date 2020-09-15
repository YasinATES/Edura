using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Entity
{
    public class Image
    {
        public int ImageId { get; set; }
        public String ImageName { get; set; }
        public int PrdouctId { get; set; }
        public Product Product { get; set; }
    }
}
