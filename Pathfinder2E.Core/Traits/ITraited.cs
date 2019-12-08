using System.Collections.Generic;

namespace Pathfinder2E.Core.Traits
{
    /// <summary>
    /// Represents a type which has <see cref="Trait"/>s.
    /// </summary>
    public interface ITraited
    {
        /// <summary>
        /// Gets all <see cref="Trait"/>s.
        /// </summary>
        IReadOnlyCollection<Trait> GetTraits();
    }
}