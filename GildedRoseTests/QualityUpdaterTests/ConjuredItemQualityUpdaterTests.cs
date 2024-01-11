using GildedRoseKata.QualityUpdaters;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests.QualityUpdaterTests
{
    public class ConjuredItemQualityUpdaterTests
    {
        [Test]
        public void DecrementSellInByOneAndQualityByTwo_WhenSellInIsAboveZero()
        {
            var item = new Item { Name = ItemNames.Conjured, SellIn = 50, Quality = 50 };
            UpdateQuality(item);

            Assert.That(item.Quality, Is.EqualTo(48));
            Assert.That(item.SellIn, Is.EqualTo(49));
        }

        [Test]
        public void DecrementSellInByOneAndQualityByFour_WhenSellInIsBelowZero()
        {
            var item = new Item { Name = ItemNames.Conjured, SellIn = -1, Quality = 50 };
            UpdateQuality(item);

            Assert.That(item.Quality, Is.EqualTo(46));
            Assert.That(item.SellIn, Is.EqualTo(-2));
        }

        private static void UpdateQuality(Item item)
        {
            var updater = new ConjuredItemQualityUpdater();
            updater.UpdateQuality(item);
        }
    }
}
