namespace Pathfinder2E.Core.Spells
{
    /// <summary>
    /// Requirements to cast a spell.
    /// </summary>
    public enum SpellComponent
    {
        /// <summary>
        /// A focus is an object that funnels the magical energy of the spell.
        /// </summary>
        Focus,

        /// <summary>
        /// A material component is a bit of physical matter consumed in the casting of the spell.
        /// </summary>
        Material,

        /// <summary>
        /// A somatic component is a specific hand movement or gesture that generates a magical nexus.
        /// </summary>
        Somatic,

        /// <summary>
        /// A verbal component is a vocalization of words of power.
        /// </summary>
        Verbal,
    }
}
