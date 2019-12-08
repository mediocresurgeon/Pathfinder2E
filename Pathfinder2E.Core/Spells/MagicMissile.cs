using System.Collections.Generic;
using Pathfinder2E.Core.Traits;

namespace Pathfinder2E.Core.Spells
{
    /// <summary>
    /// A template for the spell 'Magic Missile'.
    /// </summary>
    public sealed class MagicMissile : SpellDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagicMissile"/> class.
        /// </summary>
        /// <param name="metadata">Metadata for <see cref="MagicMissile"/>.</param>
        public MagicMissile(IRulesElementMetadata metadata)
            : base(metadata, Trait.Evocation)
        {
            Components = new SpellComponents[] { SpellComponents.Somatic, SpellComponents.Verbal };
            Traits = new Trait[] { Trait.Force, Trait.Arcane, Trait.Occult };
        }

        /// <inheritdoc />
        public override bool IsCantrip => false;

        /// <inheritdoc />
        public override bool IsFocusSpell => false;

        /// <inheritdoc />
        public override byte Level => 1;

        /// <inheritdoc />
        public override Rarity Rarity => Rarity.Common;

        /// <inheritdoc />
        public override IReadOnlyCollection<SpellComponents> Components { get; }

        /// <inheritdoc />
        protected override IReadOnlyCollection<Trait> Traits { get; }
    }
}
