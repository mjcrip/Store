using Store.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Entities.Sports
{
    public class League : BaseEntity
    {
        [ForeignKey("SportId")]
        public Sport Sport { get; set; }
        public string Description { get; set; }
        public int SportId { get; set; }
    }
}
