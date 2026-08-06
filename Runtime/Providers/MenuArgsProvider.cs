namespace RPGFramework.Menu.SharedTypes.Providers
{
    public interface IMenuArgsProvider
    {
        MenuArgs Get { get; }
        void     Set(MenuArgs args);
    }

    public sealed class MenuArgsProvider : IMenuArgsProvider
    {
        private MenuArgs m_Args;

        MenuArgs IMenuArgsProvider.Get => m_Args;

        void IMenuArgsProvider.Set(MenuArgs args) => m_Args = args;
    }
}