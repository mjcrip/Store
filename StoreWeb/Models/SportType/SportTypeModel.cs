using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreWeb.Models.SportType
{
    public class SportTypeModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}