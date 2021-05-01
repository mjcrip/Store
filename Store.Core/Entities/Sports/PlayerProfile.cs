using Store.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Entities.Sports
{
    public class PlayerProfile : BaseEntity
    {
        public Gender Gender { get; set; }
        public string Description { get; set; }
        [ForeignKey("PlayerId")]
        public Player Player { get; set; }
        public int PlayerId { get; set; }
        public string Breif { get; set; }
     }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
