using System;
using System.ComponentModel.DataAnnotations;

namespace Store.Core.Base
{
    public class BaseEntity
	{
		public BaseEntity()
		{
			this.CreatedDate = DateTime.Now;
			this.IsDeleted = false;
		}

		[Key]
		public int Id { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public bool IsDeleted { get; set; }
		public string UpdatedBy { get; set; }
		public string CreatedBy { get; set; }
		public string DeletedBy { get; set; }
	}
}
