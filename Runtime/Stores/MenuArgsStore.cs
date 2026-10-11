namespace RPGFramework.Menu.SharedTypes.Stores
{
    /// <summary>
    /// Which menu the menu module opens first: set by whatever opens the menu module, read as it enters.
    /// </summary>
    public interface IMenuArgsStore
    {
        /// <summary>The menu to open first.</summary>
        MenuArgs Args { get; }

        /// <summary>Sets the menu the menu module opens first.</summary>
        void Set(MenuArgs args);
    }
}