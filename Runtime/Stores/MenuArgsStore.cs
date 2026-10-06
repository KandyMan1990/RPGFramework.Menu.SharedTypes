namespace RPGFramework.Menu.SharedTypes.Stores
{
    public interface IMenuArgsStore
    {
        MenuArgs Args { get; }
        void     Set(MenuArgs args);
    }

    public sealed class MenuArgsStore : IMenuArgsStore
    {
        private MenuArgs m_Args;

        MenuArgs IMenuArgsStore.Args => m_Args;

        void IMenuArgsStore.Set(MenuArgs args) => m_Args = args;
    }
}