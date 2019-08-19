using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentProject.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<OrganizationType> OrganizationTypes { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public new DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<Person> Persons { get; set; }
        public new DbSet<Role> Roles { get; set; }
        public DbSet<OrganizationRoleUser> OrganizationRoleUser { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrganizationAddress> OrganizationAddresses { get; set; }
        public DbSet<PersonAddress> PersonAddress { get; set; }

        


    }
}
