using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Hospital_Mgt.Domain.Models.ApplicationUser
{
    public class ApplicationUser : IdentityUser
    {
        public int Position { get; set; }
    }
}