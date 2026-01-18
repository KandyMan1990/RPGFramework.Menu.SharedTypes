using System;
using System.Threading.Tasks;
using RPGFramework.Core.SharedTypes;

namespace RPGFramework.Menu.SharedTypes
{
    public enum MenuType
    {
        Inventory,
        Abilities,
        CharacterInfo,
        Config,
        Save
    }
    
    public interface IMenuTypeProvider
    {
        Type GetType(MenuType type);
    }
    
    public interface IMenuModuleArgs : IModuleArgs
    {
        Type MenuType { get; }
    }

    public readonly struct GenericMenuModuleArgs<TMenu> : IMenuModuleArgs
    {
        public Type MenuType => typeof(TMenu);
    }

    public readonly struct MenuModuleArgs : IMenuModuleArgs
    {
        public Type MenuType { get; }

        public MenuModuleArgs(Type menuType)
        {
            MenuType = menuType;
        }
    }

    public interface IMenuModule : IModule
    {
        Task PushMenu(IMenuModuleArgs menuModuleArgs);
        Task PopMenu();
        bool IsMenuInStack<T>();
    }
}