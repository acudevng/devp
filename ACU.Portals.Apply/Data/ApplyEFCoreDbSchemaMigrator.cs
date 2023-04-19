using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace ACU.Portals.Apply.Data;

public class ApplyEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public ApplyEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ApplyDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ApplyDbContext>()
            .Database
            .MigrateAsync();
    }
}
