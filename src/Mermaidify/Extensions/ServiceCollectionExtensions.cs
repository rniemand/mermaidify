using System.Diagnostics.CodeAnalysis;
using Mermaidify.Runners;
using Mermaidify.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Rn.NetCore.Common.Logging;

namespace Mermaidify.Extensions;

[ExcludeFromCodeCoverage]
static class ServiceCollectionExtensions
{
  public static IServiceCollection AddMermaidify(this IServiceCollection services, IConfiguration configuration)
  {
    services.TryAddSingleton(configuration);
    services.TryAddSingleton(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));

    return services
      .AddSingleton<IMermaidifyRunner, MermaidifyRunner>()
      .AddSingleton<ICommandParser, CommandParser>();
  }
}
