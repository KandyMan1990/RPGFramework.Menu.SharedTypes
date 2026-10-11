namespace RPGFramework.Menu.SharedTypes.Constants
{
    /// <summary>What the menu tells Core happened as its last menu closes, for the game's module router to route.</summary>
    public static class MenuOutcomes
    {
        /// <summary>Closed, back to whatever it opened over.</summary>
        public const byte CLOSED = 1;

        /// <summary>A playthrough began or was loaded: the game goes to the module it is in.</summary>
        public const byte PLAYTHROUGH = 2;
    }
}
