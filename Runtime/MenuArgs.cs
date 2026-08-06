using System.Runtime.InteropServices;

namespace RPGFramework.Menu.SharedTypes
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct MenuArgs
    {
        public byte MenuId { get; }

        public MenuArgs(byte menuId)
        {
            MenuId = menuId;
        }
    }
}