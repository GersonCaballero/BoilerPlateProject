using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Grintsys.SROverview.Authorization.Roles;
using Grintsys.SROverview.Authorization.Users;
using Grintsys.SROverview.MultiTenancy;
using Microsoft.EntityFrameworkCore.Internal;
using Grintsys.SROverview.Employees;

namespace Grintsys.SROverview.EntityFrameworkCore
{
    public class SROverviewDbContext : AbpZeroDbContext<Tenant, Role, User, SROverviewDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Employee> Employees { get; set; }

        public SROverviewDbContext(DbContextOptions<SROverviewDbContext> options)
            : base(options)
        {
        }
    }
}
