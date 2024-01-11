using GildedRoseKata;
using GildedRoseKata.QualityUpdaters;
using NUnit.Framework;

namespace GildedRoseTests
{
    public class QualityUpdaterFactoryTests
    {
        [Test]
        public void ReturnsAgedBrieQualityUpdater_ForAgedBrieItem()
        {
            var item = new Item { Name = ItemNames.AgedBrie };
            var updater = QualityUpdaterFactory.CreateQualityUpdater(item);
            Assert.That(updater, Is.InstanceOf<AgedBrieQualityUpdater>());
        }

        [Test]
        public void ReturnsBackstagePassQualityUpdater_ForBackstagePassItem()
        {
            var item = new Item { Name = ItemNames.BackstagePass };
            var updater = QualityUpdaterFactory.CreateQualityUpdater(item);
            Assert.That(updater, Is.InstanceOf<BackstagePassQualityUpdater>());
        }

        [Test]
        public void ReturnsSulfurasQualityUpdater_ForSulfurasItem()
        {
            var item = new Item { Name = ItemNames.Sulfuras };
            var updater = QualityUpdaterFactory.CreateQualityUpdater(item);
            Assert.That(updater, Is.InstanceOf<SulfurasQualityUpdater>());
        }

        [Test]
        public void ReturnsStandardItemQualityUpdater_ForAnyOtherString()
        {
            var item = new Item { Name = "SomethingElse" };
            var updater = QualityUpdaterFactory.CreateQualityUpdater(item);
            Assert.That(updater, Is.InstanceOf<StandardItemQualityUpdater>());
        }
    }
}
