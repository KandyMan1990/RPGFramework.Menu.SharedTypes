using RPGFramework.Hashing;

namespace RPGFramework.Menu.SharedTypes.Constants
{
    /// <summary>
    /// The framework's menus, each the hash of its name: what <see cref="MenuArgs" /> and
    /// <see cref="IMenuModule.PushMenu" /> take, and the name the menu UI provider holds its layout under. A game names its
    /// own menus the same way, and adds them to the menu database in its menu scene's installer.
    /// </summary>
    public static class MenuIds
    {
        /// <summary>The name of the title menu: New Game, Load Game, Settings and Quit.</summary>
        public const string BEGIN = "Begin";

        /// <summary>The name of the Config menu: language, volumes and message speeds.</summary>
        public const string CONFIG = "Config";

        /// <summary>The name of the Language menu.</summary>
        public const string LANGUAGE = "Language";

        /// <summary>The name of the Controls page, opened from Config.</summary>
        public const string CONTROLS = "Controls";

        /// <summary>The name of the party menu, opened from the field.</summary>
        public const string PARTY = "Party";

        /// <summary>The name of the Save menu.</summary>
        public const string SAVE = "Save";

        /// <summary>The name of the Load menu.</summary>
        public const string LOAD = "Load";

        public static readonly ulong Begin = Fnv1a64.Hash(BEGIN);

        public static readonly ulong Config = Fnv1a64.Hash(CONFIG);

        public static readonly ulong Language = Fnv1a64.Hash(LANGUAGE);

        public static readonly ulong Controls = Fnv1a64.Hash(CONTROLS);

        public static readonly ulong Party = Fnv1a64.Hash(PARTY);

        public static readonly ulong Save = Fnv1a64.Hash(SAVE);

        public static readonly ulong Load = Fnv1a64.Hash(LOAD);
    }
}
