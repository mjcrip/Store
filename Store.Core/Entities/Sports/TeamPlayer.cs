using Store.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Entities.Sports
{
    public class TeamPlayer: BaseEntity
    {
        [ForeignKey("TeamId")]
        public Team Team { get; set; }
        public int TeamId { get; set; }
        [ForeignKey("PlayerId")]
        public Player Player { get; set; }
        public int PlayerId { get; set; }
        public DateTime AssocitedFrom { get; set; }
        public DateTime? AssociatedTo { get; set; }
    }
}
