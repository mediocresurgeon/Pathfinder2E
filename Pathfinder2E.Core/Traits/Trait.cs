namespace Pathfinder2E.Core.Traits
{
    /// <summary>
    /// A trait is a keyword that conveys additional information about a rules element,
    /// such as a school of magic or rarity.
    /// Often, a trait indicates how other rules interact with
    /// an ability, creature, item, or another rules element that has that trait.
    /// </summary>
    public enum Trait
    {
        /// <summary>
        /// Effects and magic items with this trait are associated with
        /// the abjuration school of magic, typically involving protection or wards.
        /// </summary>
        Abjuration,

        /// <summary>
        /// Effects with this trait deal acid damage.
        /// </summary>
        Acid,

        /// <summary>
        /// Feats with the additive trait allow you to spend actions to add special substances to bombs or elixirs.
        /// </summary>
        Additive,

        /// <summary>
        /// Effects with the air trait either manipulate or conjure air.
        /// </summary>
        Air,

        /// <summary>
        /// Alchemical items are powered by reactions of alchemical reagents.
        /// </summary>
        Alchemical,

        /// <summary>
        /// This magic comes from the arcane tradition,
        /// which is built on logic and rationality.
        /// </summary>
        Arcane,

        /// <summary>
        /// This feat belongs to an archetype.
        /// </summary>
        Archetype,

        /// <summary>
        /// An ability with this trait involves an attack.
        /// </summary>
        Attack,

        /// <summary>
        /// Auditory actions and effects rely on sound.
        /// An action with the auditory trait can be successfully performed
        /// only if the creature using the action can speak
        /// or otherwise produce the required sounds.
        /// </summary>
        Auditory,

        /// <summary>
        /// An aura is an emanation that continually ebbs out from you,
        /// affecting creatures within a certain radius.
        /// <see cref="Aura" /> can also refer to the magical signature of an item or a creature with a strong alignment.
        /// </summary>
        Aura,

        /// <summary>
        /// A spell you can cast at will that is automatically heightened to half your level rounded up.
        /// </summary>
        Cantrip,

        /// <summary>
        /// Chaotic effects often manipulate energy from chaos-aligned Outer Planes
        /// and are anathema to lawful divine servants or divine servants of lawful deities.
        /// </summary>
        Chaotic,

        /// <summary>
        /// A trait for some monster abilities.
        /// </summary>
        Charm,

        /// <summary>
        /// Effects with this trait deal cold damage.
        /// </summary>
        Cold,

        /// <summary>
        /// An item with this trait can be worn by an animal companion or similar creature.
        /// </summary>
        Companion,

        /// <summary>
        /// A hazard with this trait takes turns in an encounter.
        /// </summary>
        Complex,

        /// <summary>
        /// To cast a composition cantrip or focus spell, you usually use a type of Performance.
        /// The spell gains all the traits of the performance you used.
        /// </summary>
        Composition,

        /// <summary>
        /// An action with this trait requires a degree of mental concentration and discipline.
        /// </summary>
        Concentrate,

        /// <summary>
        /// A consecration spell enhances an area for an extended period of time.
        /// </summary>
        Conecration,

        /// <summary>
        /// Effects and magic items with this trait are associated with
        /// the conjuration school of magic, typically involving
        /// summoning, creation, teleportation, or moving things from place to place.
        /// </summary>
        Conjuration,

        /// <summary>
        /// This poison is delivered by contact with the skin.
        /// </summary>
        Contact,

        /// <summary>
        /// A curse is an effect that places some long-term affliction on a creature.
        /// </summary>
        Curse,

        /// <summary>
        /// Darkness effects extinguish non-magical light in the area, and can counteract less powerful magical light.
        /// </summary>
        Darkness,

        /// <summary>
        /// An effect with the death trait kills you immediately if it reduces you to 0 HP.
        /// </summary>
        Death,

        /// <summary>
        /// You must select a feat with this trait to apply an archetype to your character.
        /// </summary>
        Dedication,

        /// <summary>
        /// Effects with this trait attempt to determine the presence or location of a person, object, or aura.
        /// </summary>
        Detection,

        /// <summary>
        /// An effect with this trait applies one or more diseases.
        /// </summary>
        Disease,

        /// <summary>
        /// The divination school of magic typically involves
        /// obtaining or transferring information, or predicting events.
        /// </summary>
        Divination,

        /// <summary>
        /// This magic comes from the divine tradition, drawing power from deities or similar sources.
        /// </summary>
        Divine,

        /// <summary>
        /// An activity with this trait takes a day or more, and can be used only during downtime.
        /// </summary>
        Downtime,

        /// <summary>
        /// A medicine or other substance which has
        /// a physiological effect when ingested or otherwise introduced into the body.
        /// </summary>
        Drug,

        /// <summary>
        /// Effects with the earth trait either manipulate or conjure earth.
        /// </summary>
        Earth,

        /// <summary>
        /// Effects with this trait deal electricity damage.
        /// </summary>
        Electricity,

        /// <summary>
        /// This effect alters a creature’s emotions.
        /// Effects with this trait always have the mental trait as well.
        /// </summary>
        Emotion,

        /// <summary>
        /// Effects and magic items with this trait are associated with
        /// the enchantment school of magic, typically involving
        /// mind control, emotion alteration, and other mental effects.
        /// </summary>
        Enchantment,

        /// <summary>
        /// A hazard with this trait is something dangerous
        /// that’s part of the natural world, such as quicksand or harmful mold.
        /// </summary>
        Environmental,

        /// <summary>
        /// Evil effects often manipulate energy from evil-aligned Outer Planes
        /// and are antithetical to good divine servants or divine servants of good deities.
        /// </summary>
        Evil,

        /// <summary>
        /// Effects and magic items with this trait are associated wit
        /// the evocation school of magic, typically involving
        /// energy and elemental forces.
        /// </summary>
        Evocation,

        /// <summary>
        /// An activity with this trait takes more than a turn to use,
        /// and can usually be used only during exploration mode.
        /// </summary>
        Exploration,

        /// <summary>
        /// This effect or item creates an extradimensional space.
        /// </summary>
        Extradimensional,

        /// <summary>
        /// Fear effects evoke the emotion of fear.
        /// Effects with this trait always have the mental and emotion traits as well.
        /// </summary>
        Fear,

        /// <summary>
        /// Effects with the fire trait deal fire damage or either conjure or manipulate fire.
        /// </summary>
        Fire,

        /// <summary>
        /// Flourish actions are actions that require too much exertion to perform a large number in a row.
        /// </summary>
        Flourish,

        /// <summary>
        /// An item with this trait can give you an additional Focus Point.
        /// </summary>
        Focused,

        /// <summary>
        /// Effects with this trait deal force damage or create objects made of pure magical force.
        /// </summary>
        Force,

        /// <summary>
        /// A fortune effect beneficially alters how you roll your dice.
        /// </summary>
        Fortune,

        /// <summary>
        /// A type of feat that any character can select,
        /// regardless of ancestry and class, as long as they meet the prerequisites.
        /// </summary>
        General,

        /// <summary>
        /// Good effects often manipulate energy from good-aligned Outer Planes
        /// and are antithetical to evil divine servants or divine servants of evil deities.
        /// </summary>
        Good,

        /// <summary>
        /// A hazard with this trait is a spiritual echo, often of someone with a tragic death.
        /// </summary>
        Haunt,

        /// <summary>
        /// A healing effect restores a creature’s body, typically by restoring Hit Points,
        /// but sometimes by removing diseases or other debilitating effects.
        /// </summary>
        Healing,

        /// <summary>
        /// Effects and magic items with this trait are associated with
        /// the illusion school of magic, typically involving
        /// false sensory stimuli.
        /// </summary>
        Illusion,

        /// <summary>
        /// An ability with this trait can take a character
        /// completely out of the fight or even kill them,
        /// and it’s harder to use on a more powerful character.
        /// </summary>
        Incapacitation,

        /// <summary>
        /// An incorporeal creature or object has no physical form.
        /// </summary>
        Incorporeal,

        /// <summary>
        /// You created an alchemical item with the infused trait using your infused reagents,
        /// and it has a limited time before it becomes inert.
        /// </summary>
        Infused,

        /// <summary>
        /// Instinct abilities require a specific instinct;
        /// you lose access if you perform acts anathema to your instinct.
        /// </summary>
        Instinct,

        /// <summary>
        /// Lawful effects often manipulate energy from law-aligned Outer Planes
        /// and are antithetical to chaotic divine servants or divine servants of chaotic deities.
        /// </summary>
        Lawful,

        /// <summary>
        /// Light effects overcome non-magical darkness in the area,
        /// and can counteract magical darkness.
        /// </summary>
        Light,

        /// <summary>
        /// An effect with this trait depends on language comprehension.
        /// </summary>
        Linguistic,

        /// <summary>
        /// Litanies are special devotion spells,
        /// typically used by champions and requiring a single action,
        /// that usually give temporary immunity to further litanies.
        /// </summary>
        Litany,

        /// <summary>
        /// Something with the magical trait is imbued with
        /// magical energies not tied to a specific tradition of magic.
        /// </summary>
        Magical,

        /// <summary>
        /// You must physically manipulate an item or make gestures to use an action with this trait.
        /// </summary>
        Manipulate,

        /// <summary>
        /// A hazard with this trait is a constructed physical object.
        /// </summary>
        Mechanical,

        /// <summary>
        /// A mental effect can alter the target’s mind.
        /// </summary>
        Mental,

        /// <summary>
        /// Actions with the metamagic trait,
        /// usually from metamagic feats,
        /// tweak the properties of your spells.
        /// </summary>
        Metamagic,

        /// <summary>
        /// Minions are creatures that directly serve another creature. 
        /// </summary>
        Minion,

        /// <summary>
        /// A misfortune effect detrimentally alters how you roll your dice.
        /// </summary>
        Misfortune,

        /// <summary>
        /// Effects that slightly alter a creature’s form have the morph trait.
        /// </summary>
        Morph,

        /// <summary>
        /// An action with this trait involves moving from one space to another.
        /// </summary>
        Move,

        /// <summary>
        /// Archetypes with the multiclass trait represent
        /// diversifying your training into another class’s specialties.
        /// </summary>
        Multiclass,

        /// <summary>
        /// Effects and magic items with this trait are associated with
        /// the necromancy school of magic, typically involving
        /// forces of life and death.
        /// </summary>
        Necromancy,

        /// <summary>
        /// Effects with this trait
        /// heal undead creatures with negative energy,
        /// deal negative damage to living creatures,
        /// or manipulate negative energy.
        /// </summary>
        Negative,

        /// <summary>
        /// Oaths add an additional tenet to your code.
        /// </summary>
        Oath,

        /// <summary>
        /// This magic comes from the occult tradition,
        /// calling upon bizarre and ephemeral mysteries.
        /// </summary>
        Occult,

        /// <summary>
        /// These maneuvers work only as the first salvo on your turn.
        /// </summary>
        Open,

        /// <summary>
        /// These effects transform the target into a new form.
        /// </summary>
        Polymorph,

        /// <summary>
        /// Effects with this trait
        /// heal living creatures with positive energy,
        /// deal positive energy damage to undead,
        /// or manipulate positive energy.
        /// </summary>
        Positive,

        /// <summary>
        /// Effects with this trait allow a creature to project its mind and spirit into a target.
        /// </summary>
        Possession,

        /// <summary>
        /// Valuable materials with special properties have the precious trait.
        /// </summary>
        Precious,

        /// <summary>
        /// Effects with this trait determine what is likely to happen in the near future.
        /// </summary>
        Prediction,

        /// <summary>
        /// Actions with this trait allow you to follow up earlier attacks.
        /// </summary>
        Press,

        /// <summary>
        /// This magic comes from the primal tradition,
        /// connecting to the natural world and instinct.
        /// </summary>
        Primal,

        /// <summary>
        /// You must be raging to use abilities with the rage trait,
        /// and they end automatically when you stop raging.
        /// </summary>
        Rage,

        /// <summary>
        /// While all weapons need some amount of time to get into position,
        /// many ranged weapons also need to be loaded and reloaded.
        /// </summary>
        Reload,

        /// <summary>
        /// Effects with this trait see things as they truly are.
        /// </summary>
        Revelation,

        /// <summary>
        /// Ancient dwarven blacksmiths in Saggorak designed a series of spectacularly powerful runes.
        /// </summary>
        Saggorak,

        /// <summary>
        /// A scrying effect lets you see, hear, or otherwise get sensory information
        /// from a distance using a sensor or apparatus, rather than your own eyes and ears.
        /// </summary>
        Scrying,

        /// <summary>
        /// The GM rolls the check for this ability in secret.
        /// </summary>
        Secret,

        /// <summary>
        /// This magic involves shadows or the energy of the Shadow Plane.
        /// </summary>
        Shadow,

        /// <summary>
        /// A general feat with the skill trait improves your
        /// skills and their actions or gives you new actions for a skill.
        /// </summary>
        Skill,

        /// <summary>
        /// This effect can cause a creature to fall asleep or get drowsy.
        /// </summary>
        Sleep,

        /// <summary>
        /// An effect with the sonic trait functions only if it makes sound,
        /// meaning it has no effect in an area of silence or in a vacuum.
        /// </summary>
        Sonic,

        /// <summary>
        /// f an attack with a splash weapon fails, succeeds,
        /// or critically succeeds,
        /// all creatures within 5 feet of the target (including the target)
        /// take the listed splash damage.
        /// </summary>
        Splash,

        /// <summary>
        /// A stance is a general combat strategy that you enter
        /// by using an action with the stance trait, and that you remain in for some time.
        /// </summary>
        Stance,

        /// <summary>
        /// A creature called by a conjuration spell or effect gains the summoned trait.
        /// </summary>
        Summoned,

        /// <summary>
        /// A tattoo is a type of item that is drawn or cut
        /// into a creature’s skin and usually takes the form of images or symbols.
        /// </summary>
        Tattoo,

        /// <summary>
        /// Communication of thoughts or ideas by means other than the known senses.
        /// </summary>
        Telepathy,

        /// <summary>
        /// Teleportation effects allow you to instantaneously move from one point in space to another.
        /// </summary>
        Teleportation,

        /// <summary>
        /// Effects and magic items with this trait are associated with
        /// the transmutation school of magic, typically
        /// changing something’s form.
        /// </summary>
        Transmutation,

        /// <summary>
        /// A hazard or item with this trait is constructed to hinder interlopers.
        /// </summary>
        Trap,

        /// <summary>
        /// Afflictions with the virulent trait are harder to remove.
        /// </summary>
        Virulent,

        /// <summary>
        /// A visual effect can affect only creatures that can see it.
        /// </summary>
        Visual,

        /// <summary>
        /// Effects with the water trait either manipulate or conjure water.
        /// </summary>
        Water,
    }
}
