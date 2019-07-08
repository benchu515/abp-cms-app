using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CMS_Assignment.Authorization.Roles;
using CMS_Assignment.Authorization.Users;
using CMS_Assignment.MultiTenancy;
using CMS_Assignment.Pages;

namespace CMS_Assignment.EntityFrameworkCore
{
    public class CMS_AssignmentDbContext : AbpZeroDbContext<Tenant, Role, User, CMS_AssignmentDbContext>
    {
        public DbSet<Page> Pages { get; set; }
        /* Define a DbSet for each entity of the application */
        
        public CMS_AssignmentDbContext(DbContextOptions<CMS_AssignmentDbContext> options)
            : base(options)
        {
        }
    }
}
