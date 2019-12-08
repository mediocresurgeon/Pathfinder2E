using System;
using System.Linq;
using System.Collections.Generic;
using Pathfinder2E.Core.Traits;
using System.Collections.ObjectModel;

namespace Pathfinder2E.Core.Spells
{
    /// <summary>
    /// A template for a spell, such as Magic Missile.
    /// </summary>
    public abstract class SpellDescription : ISpellDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpellDescription"/> class.
        /// </summary>
        /// <param name="metadata">Metadata for this <see cref="SpellDescription"/>.</param>
        /// <param name="school">The school of magic this spell belongs to.</param>
        /// <exception cref="ArgumentException">The <paramref name="school"/> parameter is not a valid school of magic.</exception>
        public SpellDescription(IRulesElementMetadata metadata, Trait school)
        {
            if (!school.IsSchoolTrait())
            {
                throw new ArgumentException($"{school} is not a valid school trait.", nameof(school));
            }

            Metadata = metadata;
            School = school;

        }

        /// <inheritdoc />
        public IRulesElementMetadata Metadata { get; }

        /// <inheritdoc />
        public Trait School { get; private set; }

        /// <inheritdoc />
        public abstract bool IsCantrip { get; }

        /// <inheritdoc />
        public abstract bool IsFocusSpell { get; }

        /// <summary>
        /// Gets this spell's non-dynamic traits.
        /// </summary>
        protected abstract IReadOnlyCollection<Trait> Traits { get; }

        /// <inheritdoc />
        public virtual IReadOnlyCollection<Trait> Traditions => new ReadOnlyCollection<Trait>(Traits.Where(TraitExtensions.IsTraditionTrait).ToArray());

        /// <inheritdoc />
        public abstract IReadOnlyCollection<SpellComponents> Components { get; }

        /// <inheritdoc />
        public abstract byte Level { get; }

        /// <inheritdoc />
        public abstract Rarity Rarity { get; }

        /// <inheritdoc />
        public virtual IReadOnlyCollection<Trait> GetTraits()
        {
            // create a copy of the existing traits
            var traits = Traits.ToHashSet(); 

            // add in traits which are defined by spell components
            foreach (var trait in Components.Select(SpellComponentExtensions.GetAssociatedTrait))
            {
                traits.Add(trait);
            }

            return traits;
        }
    }
}
