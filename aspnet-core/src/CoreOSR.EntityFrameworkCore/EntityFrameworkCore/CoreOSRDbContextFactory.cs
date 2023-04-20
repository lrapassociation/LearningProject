using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CoreOSR.Configuration;
using CoreOSR.Web;

namespace CoreOSR.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CoreOSRDbContextFactory : IDesignTimeDbContextFactory<CoreOSRDbContext>
    {
        public CoreOSRDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CoreOSRDbContext>();

            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder(),
                addUserSecrets: true
            );

            CoreOSRDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CoreOSRConsts.ConnectionStringName));

            return new CoreOSRDbContext(builder.Options);
        }
    }
}
