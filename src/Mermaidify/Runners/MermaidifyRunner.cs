using Mermaidify.Utils;
using Rn.NetCore.Common.Logging;

namespace Mermaidify.Runners;

interface IMermaidifyRunner
{
  Task RunAsync(string cmdLineArgs);
}

class MermaidifyRunner : IMermaidifyRunner
{
  private readonly ILoggerAdapter<MermaidifyRunner> _logger;
  private readonly ICommandParser _cmdParser;

  public MermaidifyRunner(ILoggerAdapter<MermaidifyRunner> logger,
    ICommandParser cmdParser)
  {
    _logger = logger;
    _cmdParser = cmdParser;
  }


  public async Task RunAsync(string cmdLineArgs)
  {




    await Task.CompletedTask;
  }
}
