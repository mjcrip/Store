using Store.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Entities.Sports
{
    public class Sport : BaseEntity
    {
        public string Name { get; set; }
        [ForeignKey("TypeId")]
        public SportType Type { get; set; }
        public int TypeId { get; set; }
        public Excercise Excercise { get; set; }
        public string Description { get; set; }
    }
}
