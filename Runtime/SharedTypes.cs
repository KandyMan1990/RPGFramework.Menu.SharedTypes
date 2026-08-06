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
    }
}