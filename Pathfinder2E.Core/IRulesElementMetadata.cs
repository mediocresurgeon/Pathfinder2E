using System;

namespace Pathfinder2E.Core
{
    /// <summary>
    /// Language-dependency information about a game object,
    /// translated into the user's preferred language.
    /// </summary>
    public interface IRulesElementMetadata
    {
        /// <summary>
        /// The name of the game object.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// An online resource for rules text for this game object.
        /// </summary>
        Uri Url { get; }
    }
}
