namespace Pathfinder2E.Core
{
    /// <summary>
    /// A game object, such as a feat, skill, language, item, class, spell, etc.
    /// </summary>
    public abstract class RulesElement : IRulesElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RulesElement"/> class.
        /// </summary>
        /// <param name="metadata">Information about this <see cref="RulesElement"/>,
        /// translated into the user's preferred language.</param>
        protected RulesElement(IRulesElementMetadata metadata)
        {
            Metadata = metadata;
        }

        /// <inheritdoc />
        public IRulesElementMetadata Metadata { get; }

        /// <inheritdoc />
        public abstract Rarity Rarity { get; }
    }
}
