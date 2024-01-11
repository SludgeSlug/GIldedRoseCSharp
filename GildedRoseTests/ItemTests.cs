using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests
{
    public class ItemTests
    {
        [Test]
        public void Depreciate_DecreasesValueByOne_WhenQualityIsAboveZero()
        {
            var item = new Item { Quality = 10 };
            item.Depreciate();
            Assert.That(item.Quality, Is.EqualTo(9));
        }

        [Test]
        public void Depreciate_DoesNotDecreaseQuality_WhenQualityIsZero()
        {
            var item = new Item { Quality = 0 };
            item.Depreciate();
            Assert.That(item.Quality, Is.EqualTo(0));
        }
    }
}
