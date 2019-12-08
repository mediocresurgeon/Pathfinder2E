namespace Pathfinder2E.Core.Traits
{
    /// <summary>
    /// Extension methods for the <see cref="Trait"/> <see langword="enum"/>.
    /// </summary>
    public static class TraitExtensions
    {
        /// <summary>
        /// Returns whether or not this <see cref="Trait"/> is an alignment.
        /// </summary>
        /// <param name="trait">The <see cref="Trait"/> to test.</param>
        /// <returns>
        /// <see langword="true"/> if the <see cref="Trait"/> is an alignment; otherwise <see langword="false"/>.
        /// </returns>
        public static bool IsAlignmentTrait(this Trait trait)
        {
            switch (trait)
            {
                case Trait.Chaotic:
                case Trait.Evil:
                case Trait.Good:
                case Trait.Lawful:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Returns whether or not this <see cref="Trait"/> is an element.
        /// </summary>
        /// <param name="trait">The <see cref="Trait"/> to test.</param>
        /// <returns>
        /// <see langword="true"/> if the <see cref="Trait"/> is an element; otherwise <see langword="false"/>.
        /// </returns>
        public static bool IsElementalTrait(this Trait trait)
        {
            switch (trait)
            {
                case Trait.Air:
                case Trait.Earth:
                case Trait.Fire:
                case Trait.Water:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Returns whether or not this <see cref="Trait"/> is an energy.
        /// </summary>
        /// <param name="trait">The <see cref="Trait"/> to test.</param>
        /// <returns>
        /// <see langword="true"/> if the <see cref="Trait"/> is an energy; otherwise <see langword="false"/>.
        /// </returns>
        public static bool IsEnergyTrait(this Trait trait)
        {
            switch (trait)
            {
                case Trait.Acid:
                case Trait.Cold:
                case Trait.Electricity:
                case Trait.Fire:
                case Trait.Force:
                case Trait.Negative:
                case Trait.Positive:
                case Trait.Sonic:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Returns whether or not this <see cref="Trait"/> is a school of magic.
        /// </summary>
        /// <param name="trait">The <see cref="Trait"/> to test.</param>
        /// <returns>
        /// <see langword="true"/> if the <see cref="Trait"/> is a school of magic; otherwise <see langword="false"/>.
        /// </returns>
        public static bool IsSchoolTrait(this Trait trait)
        {
            switch (trait)
            {
                case Trait.Abjuration:
                case Trait.Conjuration:
                case Trait.Divination:
                case Trait.Enchantment:
                case Trait.Evocation:
                case Trait.Illusion:
                case Trait.Necromancy:
                case Trait.Transmutation:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Returns whether or not this <see cref="Trait"/> is an magical tradition.
        /// </summary>
        /// <param name="trait">The <see cref="Trait"/> to test.</param>
        /// <returns>
        /// <see langword="true"/> if the <see cref="Trait"/> is a magical tradition; otherwise <see langword="false"/>.
        /// </returns>
        public static bool IsTraditionTrait(this Trait trait)
        {
            switch (trait)
            {
                case Trait.Arcane:
                case Trait.Divine:
                case Trait.Occult:
                case Trait.Primal:
                    return true;
                default:
                    return false;
            }
        }
    }
}
