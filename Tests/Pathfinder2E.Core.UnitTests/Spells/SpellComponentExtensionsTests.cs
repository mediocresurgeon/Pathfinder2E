using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pathfinder2E.Core.Spells;
using Pathfinder2E.Core.Traits;

namespace Pathfinder2E.Core.UnitTests.Spells
{
    [TestClass]
    public class SpellComponentExtensionsTests
    {
        [DataTestMethod]
        [DataRow(SpellComponent.Focus, Trait.Manipulate)]
        [DataRow(SpellComponent.Material, Trait.Manipulate)]
        [DataRow(SpellComponent.Somatic, Trait.Manipulate)]
        [DataRow(SpellComponent.Verbal, Trait.Concentrate)]
        public void ToAssociatedTrait(SpellComponent component, Trait expected)
        {
            // Arrange

            // Act
            var result = component.ToAssociatedTrait();

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}
