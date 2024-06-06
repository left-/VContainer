namespace VContainer.Unity
{
    public interface ILifetimeScope
    {
        IObjectResolver Container { get; }

        ILifetimeScope CreateChild(IInstaller installer = null);
    }
}
