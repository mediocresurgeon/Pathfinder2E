using System.Collections.Generic;
using Pathfinder2E.Core.Traits;

namespace Pathfinder2E.Core.Spells
{
    /// <summary>
    /// A template for a spell, such as Magic Missile.
    /// </summary>
    public interface ISpellDescription : IRulesElement, ITraited
    {
        /// <summary>
        /// Gets a value indicating if this spell is a cantrip.
        /// </summary>
        bool IsCantrip { get; }

        /// <summary>
        /// Gets a value indicating if this spell is a focus spell.
        /// </summary>
        bool IsFocusSpell { get; }

        /// <summary>
        /// Gets the default level of the spell.
        /// </summary>
        byte Level { get; }

        /// <summary>
        /// Gets the components of the spell.
        /// </summary>
        IReadOnlyCollection<SpellComponent> Components { get; }

        /// <summary>
        /// Gets the school of magic to which this spell belongs.
        /// </summary>
        /// <returns>
        /// One of the following:
        /// <list type="bullet">
        /// <item><see cref="Trait.Abjuration"/></item>
        /// <item><see cref="Trait.Conjuration"/></item>
        /// <item><see cref="Trait.Divination"/></item>
        /// <item><see cref="Trait.Enchantment"/></item>
        /// <item><see cref="Trait.Evocation"/></item>
        /// <item><see cref="Trait.Illusion"/></item>
        /// <item><see cref="Trait.Necromancy"/></item>
        /// <item><see cref="Trait.Transmutation"/></item>
        /// </list>
        /// </returns>
        Trait School { get; }

        /// <summary>
        /// Gets the traditions of magic to which this spell belongs.
        /// </summary>
        /// <returns>
        /// n of the following:
        /// <list type="bullet">
        /// <item><see cref="Trait.Arcane"/></item>
        /// <item><see cref="Trait.Divine"/></item>
        /// <item><see cref="Trait.Occult"/></item>
        /// <item><see cref="Trait.Primal"/></item>
        /// </list>
        /// </returns>
        IReadOnlyCollection<Trait> Traditions { get; }
    }
}
