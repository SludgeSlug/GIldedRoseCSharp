using GildedRoseKata;
using GildedRoseKata.QualityUpdaters;
using NUnit.Framework;

namespace GildedRoseTests.QualityUpdaterTests
{
    public class BackstagePassQualityUpdaterTests
    {
        [Test]
        public void MaintainsQuality_WhenSellInIsOver10Days()
        {
            var item = new Item { Name = ItemNames.BackstagePass, SellIn = 11, Quality = 50 };
            UpdateQuality(item);

            Assert.That(item.Quality, Is.EqualTo(50));
        }

        [Test]
        public void IncreasesQualityByTwo_WhenSellInLessThanEleven()
        {
            var item = new Item { Name = ItemNames.BackstagePass, SellIn = 10, Quality = 40 };
            UpdateQuality(item);

            Assert.That(item.Quality, Is.EqualTo(42));
        }

        [Test]
        public void IncreasesQualityByThree_WhenSellInLessThanSix()
        {
            var item = new Item { Name = ItemNames.BackstagePass, SellIn = 5, Quality = 40 };
            UpdateQuality(item);

            Assert.That(item.Quality, Is.EqualTo(43));
        }

        [Test]
        public void QualitySetToZero_WhenSellInLessThanZero()
        {
            var item = new Item { Name = ItemNames.BackstagePass, SellIn = -1, Quality = 50 };
            UpdateQuality(item);

            Assert.That(item.Quality, Is.EqualTo(0));
        }

        private static void UpdateQuality(Item item)
        {
            var updater = new BackstagePassQualityUpdater();
            updater.UpdateQuality(item);
        }
    }
}
