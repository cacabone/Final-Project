﻿using FinalProject.Data.Enum;
namespace FinalProject.Data.Models
{
    public class Producto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price_Per_Unit { get; set; }

        public int Stock { get; set; }

        public ProductCategory Category { get; set; }
    }
}
