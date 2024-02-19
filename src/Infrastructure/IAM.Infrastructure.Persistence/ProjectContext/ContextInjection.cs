using Microsoft.Extensions.DependencyInjection;

namespace IAM.Infrastructure.Persistence.ProjectContext;

public static class ContextInjection
{
    public static IServiceCollection AddProjectContextSQLite(this IServiceCollection services)
    {
        services.AddDbContext<SQLiteContext>(options => options.UseSqlite("Data Source=database.db"));
        return services;
    }
}
