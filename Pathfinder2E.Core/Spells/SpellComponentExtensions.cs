using System.ComponentModel;
using Pathfinder2E.Core.Traits;

namespace Pathfinder2E.Core.Spells
{
    /// <summary>
    /// Extension methods for <see cref="SpellComponents"/>.
    /// </summary>
    public static class SpellComponentExtensions
    {
        /// <summary>
        /// Gets the trait which is added to a spell when the spell has this spell component.
        /// </summary>
        /// <param name="spellComponent">The spell component.</param>
        /// <returns>The <see cref="Trait"/> associated with the spell component.</returns>
        public static Trait GetAssociatedTrait(this SpellComponents spellComponent)
        {
            switch (spellComponent)
            {
                case SpellComponents.Focus:
                case SpellComponents.Material:
                case SpellComponents.Somatic:
                    return Trait.Manipulate;
                case SpellComponents.Verbal:
                    return Trait.Concentrate;
                default:
                    throw new InvalidEnumArgumentException(nameof(spellComponent), (int)spellComponent, spellComponent.GetType());
            }
        }
    }
}
