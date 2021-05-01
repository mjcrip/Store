using Store.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Entities.Sports
{
    public class Club : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string WebsiteUrl { get; set; }
        [ForeignKey("TypeId")]
        public ClubType Type { get; set; }
        public int TypeId { get; set; }
        public string OrganizationName { get; set; }
        public string Department { get; set; }
    }
}
