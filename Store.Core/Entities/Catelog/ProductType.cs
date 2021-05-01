﻿using Store.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Entities.Catelog
{
    public class ProductType : BaseEntity
    {
        [MaxLength(50)]
        public string Prefix { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Property> Properties { get; set; }
        [NotMapped]
        public List<ProductImage> Images { get; set; }

        public List<Property> GetProperties()
        {
            return Properties.Where(p => p.IsDeleted == false).ToList();
        }
    }
}
