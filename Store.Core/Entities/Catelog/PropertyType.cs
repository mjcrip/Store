using Store.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Entities.Catelog
{
    public class PropertyType : BaseEntity
    {
        public string Prefix { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
