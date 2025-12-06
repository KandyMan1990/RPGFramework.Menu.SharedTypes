using System;
using System.Threading.Tasks;
using RPGFramework.Core.SharedTypes;

namespace RPGFramework.Menu.SharedTypes
{
    public interface IMenuModuleArgs : IModuleArgs
    {
        Type MenuType { get; }
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
        void PlaySfx(int id);
    }
}