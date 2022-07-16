using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Mermaidify.Extensions;

[ExcludeFromCodeCoverage]
static class ServiceCollectionExtensions
{
  public static IServiceCollection AddMermaidify(this IServiceCollection services, IConfiguration configuration)
  {
    services.TryAddSingleton(configuration);

    return services;
  }
}
