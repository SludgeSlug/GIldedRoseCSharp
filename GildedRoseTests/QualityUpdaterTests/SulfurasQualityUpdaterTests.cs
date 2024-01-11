using GildedRoseKata;
using GildedRoseKata.QualityUpdaters;
using NUnit.Framework;

namespace GildedRoseTests.QualityUpdaterTests
{
    public class SulfurasQualityUpdaterTests
    {
        [Test]
        public void UpdateQuality_DoesNothing()
        {
            var item = new Item { Name = ItemNames.Sulfuras, Quality = 80, SellIn = 50 };

            var qualityUpdater = new SulfurasQualityUpdater();
            qualityUpdater.UpdateQuality(item);

            Assert.That(item.Quality, Is.EqualTo(80));
            Assert.That(item.SellIn, Is.EqualTo(50));
        }
    }
}
