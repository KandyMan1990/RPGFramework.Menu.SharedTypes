using System.Threading.Tasks;
using RPGFramework.Core.SharedTypes;

namespace RPGFramework.Menu.SharedTypes
{
    public enum MenuType : byte
    {
        Begin,
        Inventory,
        Abilities,
        CharacterInfo,
        Config,
        Save,
        Language,
        Party,
        Load
    }

    /// <summary>
    /// The menu module, as Core resolves it: a stack of menus, the top one shown and taking input, faded between as
    /// each opens and closes.
    /// </summary>
    public interface IMenuModule : IModule
    {
        /// <summary>Opens a menu over the one on top, which is suspended under it.</summary>
        Task PushMenu(MenuType menuType);

        /// <summary>
        /// Closes the menu on top and resumes the one under it; closing the last leaves the menu module.
        /// </summary>
        Task PopMenu();

        /// <summary>Whether a menu of this type is open anywhere in the stack.</summary>
        bool IsMenuInStack<T>();

        /// <summary>
        /// Asks the menu module to leave with <paramref name="outcome" />, one of <c>MenuOutcomes</c>, for the game's
        /// module router to route.
        /// </summary>
        /// <remarks>
        /// Call this instead of requesting the change directly. A menu that requests one while it is still
        /// entering or resuming would be torn down mid-lifecycle — its UI destroyed underneath it and its
        /// localisation sheets unloaded and then reloaded over the incoming module's. The menu module holds
        /// the request until the menu has finished coming back up, then acts on it.
        /// </remarks>
        void RequestModuleChange(byte outcome);
    }
}