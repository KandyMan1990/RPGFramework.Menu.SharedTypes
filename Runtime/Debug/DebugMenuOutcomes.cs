#if ENABLE_RPG_FRAMEWORK_DEBUG
namespace RPGFramework.Menu.SharedTypes.Constants
{
    /// <summary>What the menu tells Core happened for the debug room, for the game's module router to route.</summary>
    public static class DebugMenuOutcomes
    {
        /// <summary>The title's Debug Room was chosen. The top of the range, clear of a game's own outcomes.</summary>
        public const byte DEBUG_ROOM = 255;
    }
}
#endif
