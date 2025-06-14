using MediaBrowser.Model.Plugins;

namespace MovieRequestPlugin.Configuration
{
    public class PluginConfiguration : BasePluginConfiguration
    {
        public string HelloMessage { get; set; } = "Hello World from Movie Request Plugin!";
    }
}