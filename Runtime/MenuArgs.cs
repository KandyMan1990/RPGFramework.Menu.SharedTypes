using System.Runtime.InteropServices;

namespace RPGFramework.Menu.SharedTypes
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct MenuArgs
    {
        /// <summary>The menu to open, the hash of its name, as <c>MenuIds</c> names the framework's.</summary>
        public ulong MenuId { get; }

        public MenuArgs(ulong menuId)
        {
            MenuId = menuId;
        }
    }
}
