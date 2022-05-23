﻿using System;

namespace EfWebApp.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}
