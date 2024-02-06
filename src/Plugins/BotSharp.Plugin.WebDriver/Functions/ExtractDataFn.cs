namespace BotSharp.Plugin.WebDriver.Functions;

public class ExtractDataFn : IFunctionCallback
{
    public string Name => "extract_data_from_page";

    private readonly IServiceProvider _services;
    private readonly IWebBrowser _browser;

    public ExtractDataFn(IServiceProvider services,
        IWebBrowser browser)
    {
        _services = services;
        _browser = browser;
    }

    public async Task<bool> Execute(RoleDialogModel message)
    {
        var args = JsonSerializer.Deserialize<BrowsingContextIn>(message.FunctionArgs);
        var agentService = _services.GetRequiredService<IAgentService>();
        var agent = await agentService.LoadAgent(message.CurrentAgentId);
        message.Content = await _browser.ExtractData(new BrowserActionParams(agent, args, message.MessageId));
        return true;
    }
}
