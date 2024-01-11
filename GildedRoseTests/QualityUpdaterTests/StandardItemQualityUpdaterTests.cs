using GildedRoseKata;
using GildedRoseKata.QualityUpdaters;
using NUnit.Framework;

namespace GildedRoseTests.QualityUpdaterTests
{
    public class StandardItemQualityUpdaterTests
    {
        [Test]
        public void DecrementSellInAndQuality_WhenSellInIsAboveZero()
        {
            var item = new Item { Name = "StandardItem", SellIn = 50, Quality = 50 };
            UpdateQuality(item);

            Assert.That(item.Quality, Is.EqualTo(49));
            Assert.That(item.SellIn, Is.EqualTo(49));
        }

        [Test]
        public void DecrementSellInByOneAndQualityByTwo_WhenSellInIsBelowZero()
        {
            var item = new Item { Name = "StandardItem", SellIn = -1, Quality = 50 };
            UpdateQuality(item);

            Assert.That(item.Quality, Is.EqualTo(48));
            Assert.That(item.SellIn, Is.EqualTo(-2));
        }

        private static void UpdateQuality(Item item)
        {
            var updater = new StandardItemQualityUpdater();
            updater.UpdateQuality(item);
        }
    }
}
