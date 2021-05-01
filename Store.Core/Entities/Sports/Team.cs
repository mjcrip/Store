using Store.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Entities.Sports
{
    public class Team : BaseEntity
    {
        [ForeignKey("SportId")]
        public Sport Sport { get; set; }
        public int SportId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("ClubId")]
        public virtual Club Club { get; set; }
        public int? ClubId { get; set; }
    }
}
