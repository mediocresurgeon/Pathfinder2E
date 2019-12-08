namespace Pathfinder2E.Core
{
    /// <summary>
    /// Represents a game concept, such as a feat, skill, language, item, class, spell, etc, which has a name and rules text.
    /// </summary>
    public interface IRulesElement
    {
        /// <summary>
        /// Language-dependency information about this <see cref="IRulesElement"/>,
        /// translated into the user's preferred language.
        /// </summary>
        IRulesElementMetadata Metadata { get; }

        /// <summary>
        /// The rarity of this <see cref="IRulesElement"/>.
        /// </summary>
        Rarity Rarity { get; }
    }
}
