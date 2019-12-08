namespace Pathfinder2E.Core
{
    /// <summary>
    /// The rarity of a rules element.
    /// </summary>
    public enum Rarity
    {
        /// <summary>
        /// This rarity indicates that an ability, item, or spell is available to all players who meet the prerequisites for it.
        /// </summary>
        Common,

        /// <summary>
        /// Some character choices give access to uncommon options, and the GM can choose to allow access for anyone.
        /// </summary>
        Uncommon,

        /// <summary>
        /// A rare feat, spell, item or the like is available to players only if the GM decides to include it in the game, typically through discovery during play.
        /// </summary>
        Rare,

        /// <summary>
        /// A rules element with this trait is one-of-a-kind.
        /// </summary>
        Unique,
    }
}
