using System.Text;
using Mermaidify.Runners;
using Mermaidify.Utils;
using Microsoft.Extensions.DependencyInjection;

var services = DIUtils.GetServiceProvider("Development");
var runner = services.GetRequiredService<IMermaidifyRunner>();

var cmdLineArgs = new StringBuilder()
  .ToString();

await runner.RunAsync(cmdLineArgs);


Console.WriteLine();
Console.WriteLine();
