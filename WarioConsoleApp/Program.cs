using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WarioConsoleApp.Data;
using WarioConsoleApp.Repositories;
using WarioConsoleApp.Services;

class Program
{
    static async Task Main()
    {
        var services = new ServiceCollection();
        services.AddDbContext<WarioDbContext>();
        services.AddTransient<WarioRepository>();
        services.AddTransient<IDataDownloader, XmlDataDownloader>();
        services.AddTransient<DataService>();
        services.AddLogging(configure => configure.AddConsole());
        var provider = services.BuildServiceProvider();
        var dataService = provider.GetRequiredService<DataService>();
        string url = "https://pastebin.com/raw/PMQueqDV";
        while(true)
        {
            await dataService.Run(url);
            await Task.Delay(TimeSpan.FromHours(1));
        }
    }
}
