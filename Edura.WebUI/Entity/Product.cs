﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Edura.WebUI.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        public String Description { get; set; }
        public String HtmlContent { get; set; }
        public DateTime DateAdded { get; set; }


        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public bool IsFeatured { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
        public List<Image> Images { get; set; }

        public List<ProductAttribute> Attributes { get; set; }
    }
}