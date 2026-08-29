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
        Language
    }

    public interface IMenuModule : IModule
    {
        Task PushMenu(MenuType menuType);
        Task PopMenu();
        bool IsMenuInStack<T>();

        /// <summary>
        /// Asks the menu module to leave for the module named by <c>IChangeModuleStore</c>.
        /// </summary>
        /// <remarks>
        /// Call this instead of requesting the change directly. A menu that requests one while it is still
        /// entering or resuming would be torn down mid-lifecycle — its UI destroyed underneath it and its
        /// localisation sheets unloaded and then reloaded over the incoming module's. The menu module holds
        /// the request until the menu has finished coming back up, then acts on it.
        /// </remarks>
        void RequestModuleChange();
    }
}