﻿using System;

namespace Rookies.ShareClassdLibrary.Dto.ProductbyCate
{
    public class ProductbyCateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int CategoryId { get; set; }
    }
}