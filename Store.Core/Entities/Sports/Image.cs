using Store.Core.Base;
using Store.Core.Entities.Catelog;
using Store.Core.Entities.Sports;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Core.Entities.Sports
{
    public class Image : BaseEntity
    {
        public string ImageUrl { get; set; }
        public string ImageThumbUrl { get; set; }
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
    }
}
