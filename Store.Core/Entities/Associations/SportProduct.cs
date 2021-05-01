using Store.Core.Base;
using Store.Core.Entities.Catelog;
using Store.Core.Entities.Sports;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Entities.Associations
{
    public class SportProduct : BaseEntity
    {
        [ForeignKey("PlayerId")]
        public virtual Player Player { get; set; }
        public int? PlayerId { get; set; }
        [ForeignKey("ClubId")]
        public virtual Club Club { get; set; }
        public int? ClubId { get; set; }
        [ForeignKey("LeagueId")]
        public virtual League League { get; set; }
        public int? LeagueId { get; set; }
        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }
        public int? TeamId { get; set; }
        [ForeignKey("SportId")]
        public virtual Sport Sport { get; set; }
        public int? SportId { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
