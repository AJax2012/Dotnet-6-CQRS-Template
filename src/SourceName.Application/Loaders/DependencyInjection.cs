using Microsoft.Extensions.DependencyInjection;
using SourceName.Application.Contracts;

namespace SourceName.Application.Loaders;

internal static class DependencyInjection
{
    internal static void RegisterDependencies(this IServiceCollection services)
    {
        services.AddTransient<IValidationHandler>();
    }
}