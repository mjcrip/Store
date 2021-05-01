using Store.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Entities.Sports
{
    public class ClubType : BaseEntity
    {
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
