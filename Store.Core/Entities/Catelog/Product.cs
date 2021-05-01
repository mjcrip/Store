using Store.Core.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Store.Core.Entities.Catelog
{
    public class Product : BaseEntity
    {
        [MaxLength(100)]
        public string Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId")]
        public ProductType Type { get; set; }
        public decimal Price { get; set; }
        public decimal SellingPrice { get; set; }
        public int Quantity { get; set; }
        public bool IsActive { get; set; }
        public string AffiliateUrl { get; set; }
        public List<Property> Properties { get; set; }
        [NotMapped]
        public List<ProductImage> ProductImages { get; set; }

        public List<Property> GetProperties()
        {
            var parentProperties = Type.GetProperties();
            List<Property> flattenedProperties = new List<Property>(Properties.Where(p => p.IsDeleted == false));
            foreach (Property prop in parentProperties)
            {
                if ((flattenedProperties.Where(p => p.PropertyTypeId == prop.PropertyTypeId && p.IsDeleted == false).Count()) == 0)
                    flattenedProperties.Add(prop);
            }
            return flattenedProperties;
        }
    }
}
