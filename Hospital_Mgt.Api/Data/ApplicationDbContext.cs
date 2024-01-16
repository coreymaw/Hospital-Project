using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hospital_Mgt.Domain;
using Hospital_Mgt.Domain.Models;
using Hospital_Mgt.Domain.Models.ApplicationUser;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Mgt.Api.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        DbSet<Doctor> Doctors {get;set;}

    }
}