namespace PluginContracts
{
    public interface IPlugin
    {
        string Name { get; }

        string Text { get; }

        void Run();
    }

}
