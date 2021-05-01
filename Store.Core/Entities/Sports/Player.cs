using Store.Core.Base;
using Store.Core.Entities.Ecosystem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Entities.Sports
{
    public class Player : BaseEntity
    {
        public Person Person { get; set; }
        [ForeignKey("SportId")]
        public Sport Sport { get; set; }
        public int SportId { get; set; }
    }
}
