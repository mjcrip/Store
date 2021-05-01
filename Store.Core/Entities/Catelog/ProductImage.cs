using Store.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Entities.Catelog
{
    public class ProductImage: BaseEntity
    {
        public string PublicUrl { get; set; }
        public string PublicThumblUrl { get; set; }
        [MaxLength(100)]
        public string FileName { get; set; }
        public int Order { get; set; }
        public bool IsDefault { get; set; }

        public EntityType? Type { get; set; }
        public int? EntityId { get; set; }
    }

    public enum EntityType
    {
        Product,
        ProductType,
        Category
    }
}
