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

        [Test]
        public void Depreciate_DecreasesByDeclaredFactor()
        {
            var item = new Item { Quality = 3 };
            item.Depreciate(2);
            Assert.That(item.Quality, Is.EqualTo(1));
        }

        [Test]
        public void Apreciate_IncreasesQuality_ByOne()
        {
            var item = new Item { Quality = 0 };
            item.Apreciate();
            Assert.That(item.Quality, Is.EqualTo(1));
        }

        [Test]
        public void Apreciate_DoesNotExceedMaxQuality()
        {
            var item = new Item { Quality = 50 };
            item.Apreciate();
            Assert.That(item.Quality, Is.EqualTo(50));
        }
    }
}
