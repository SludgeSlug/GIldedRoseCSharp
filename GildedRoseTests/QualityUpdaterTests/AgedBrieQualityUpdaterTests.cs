using GildedRoseKata;
using GildedRoseKata.QualityUpdaters;
using NUnit.Framework;

namespace GildedRoseTests.QualityUpdaterTests
{
    public class AgedBrieQualityUpdaterTests
    {
        [Test]
        public void IncreasesInQuality_WhenSellInIsAboveZero()
        {
            var item = new Item { Name = ItemNames.AgedBrie, SellIn = 1, Quality = 40 };
            UpdateQuality(item);

            Assert.That(item.Quality, Is.EqualTo(41));
        }

        [Test]
        public void IncreasesInQualityByTwo_WhenSellInIsLessThanZero()
        {
            var item = new Item { Name = ItemNames.AgedBrie, SellIn = -1, Quality = 40 };
            UpdateQuality(item);

            Assert.That(item.Quality, Is.EqualTo(42));
        }

        private static void UpdateQuality(Item item)
        {
            var updater = new AgedBrieQualityUpdater();
            updater.UpdateQuality(item);
        }
    }
}
