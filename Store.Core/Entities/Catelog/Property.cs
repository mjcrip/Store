using Store.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Entities.Catelog
{
    public class Property : BaseEntity
    {
        public int PropertyTypeId { get; set; }
        [ForeignKey("PropertyTypeId")]
        public PropertyType Type { get; set; }
        public string Value { get; set; }

        public int? CategoryId { get; set; }
        public int? ProductId { get; set; }
        public int? ProductTypeId { get; set; }
    }
}
