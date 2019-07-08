using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CMS_Assignment.Configuration;
using CMS_Assignment.Web;

namespace CMS_Assignment.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CMS_AssignmentDbContextFactory : IDesignTimeDbContextFactory<CMS_AssignmentDbContext>
    {
        public CMS_AssignmentDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CMS_AssignmentDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CMS_AssignmentDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CMS_AssignmentConsts.ConnectionStringName));

            return new CMS_AssignmentDbContext(builder.Options);
        }
    }
}
