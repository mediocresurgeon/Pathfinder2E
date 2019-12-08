using System;


namespace Pathfinder2E.Core.Traits
{
    /// <summary>
    /// Arguments for <see langword="event"/>s where <see cref="Trait"/>s are added to an object.
    /// </summary>
    public sealed class TraitAddedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TraitAddedEventArgs"/> class.
        /// </summary>
        /// <param name="trait">The trait which was added.</param>
        public TraitAddedEventArgs(Trait trait)
        {
            Added = trait;
        }

        /// <summary>
        /// Gets the <see cref="Trait"/> which was added.
        /// </summary>
        Trait Added { get; }
    }
}