using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infra.Identity
{
    public class AuthenticatedUserLogin : IdentityUserLogin<int>
    {
        //[Key]
        public int Id { get; set; }
    }
}
