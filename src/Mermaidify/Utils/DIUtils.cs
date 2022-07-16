using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Mermaidify.Utils;

static class DIUtils
{
  public static IServiceProvider GetServiceProvider(string env = "Production")
  {
    var config = new ConfigurationBuilder()
      .AddJsonFile("Mermaidify.json", true)
      .AddJsonFile($"Mermaidify.{env}.json", true)
      .AddJsonFile("Tracker.machine.json", true)
      .Build();

    var services = new ServiceCollection()
      .AddSingleton(config)
      .AddLogging();

    return services.BuildServiceProvider();
  }
}
