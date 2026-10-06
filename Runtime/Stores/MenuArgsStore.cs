namespace RPGFramework.Menu.SharedTypes.Stores
{
    public interface IMenuArgsStore
    {
        MenuArgs Args { get; }
        void     Set(MenuArgs args);
    }
}