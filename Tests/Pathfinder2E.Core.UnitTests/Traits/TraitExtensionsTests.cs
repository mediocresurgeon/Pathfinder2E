using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pathfinder2E.Core.Traits;

namespace Pathfinder2E.Core.UnitTests.Traits
{
    [TestClass]
    public class TraitExtensionTests
    {
        [DataTestMethod]
        [DataRow(Trait.Chaotic)]
        [DataRow(Trait.Evil)]
        [DataRow(Trait.Good)]
        [DataRow(Trait.Lawful)]
        public void IsAlignmentTrait_True(Trait trait)
        {
            // Arrange

            // Act
            bool result = trait.IsAlignmentTrait();

            // Assert
            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow(Trait.Air)]
        [DataRow(Trait.Earth)]
        [DataRow(Trait.Fire)]
        [DataRow(Trait.Water)]
        public void IsElementalTrait_True(Trait trait)
        {
            // Arrange

            // Act
            bool result = trait.IsElementalTrait();

            // Assert
            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow(Trait.Acid)]
        [DataRow(Trait.Cold)]
        [DataRow(Trait.Electricity)]
        [DataRow(Trait.Fire)]
        [DataRow(Trait.Force)]
        [DataRow(Trait.Negative)]
        [DataRow(Trait.Positive)]
        [DataRow(Trait.Sonic)]
        public void IsEnergyTrait_True(Trait trait)
        {
            // Arrange

            // Act
            bool result = trait.IsEnergyTrait();

            // Assert
            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow(Trait.Abjuration)]
        [DataRow(Trait.Conjuration)]
        [DataRow(Trait.Divination)]
        [DataRow(Trait.Enchantment)]
        [DataRow(Trait.Evocation)]
        [DataRow(Trait.Illusion)]
        [DataRow(Trait.Necromancy)]
        [DataRow(Trait.Transmutation)]
        public void IsSchoolTrait_True(Trait trait)
        {
            // Arrange

            // Act
            bool result = trait.IsSchoolTrait();

            // Assert
            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow(Trait.Arcane)]
        [DataRow(Trait.Divine)]
        [DataRow(Trait.Occult)]
        [DataRow(Trait.Primal)]
        public void IsTraditionTrait_True(Trait trait)
        {
            // Arrange

            // Act
            bool result = trait.IsTraditionTrait();

            // Assert
            Assert.IsTrue(result);
        }
    }
}
