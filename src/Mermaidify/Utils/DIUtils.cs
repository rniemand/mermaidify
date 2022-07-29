using System.Diagnostics.CodeAnalysis;
using Mermaidify.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Mermaidify.Utils;

[ExcludeFromCodeCoverage]
static class DIUtils
{
  public static IServiceProvider GetServiceProvider(string env = "Production")
  {
    var config = new ConfigurationBuilder()
      .AddJsonFile("Mermaidify.json", true)
      .AddJsonFile($"Mermaidify.{env}.json", true)
      .AddJsonFile("Mermaidify.machine.json", true)
      .Build();

    var services = new ServiceCollection()
      .AddMermaidify(config)
      .AddLogging();

    return services.BuildServiceProvider();
  }
}
