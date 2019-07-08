using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CMS_Assignment.EntityFrameworkCore
{
    public static class CMS_AssignmentDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CMS_AssignmentDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CMS_AssignmentDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
