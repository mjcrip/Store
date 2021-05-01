using Store.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Entities.Sports
{
    public class TeamLeague : BaseEntity
    {
        [ForeignKey("TeamId")]
        public Team Team { get; set; }
        public int TeamId { get; set; }
        [ForeignKey("LeagueId")]
        public League League { get; set; }
        public int LeagueId { get; set; }
        public bool IsActive { get; set; }
    }
}
