using System.Collections.Generic;
using System.Linq;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Test]
    public void DoNothing_WhenItemIsSulfuras()
    {
        var items = new List<Item> { new Item { Name = ItemNames.Sulfuras, SellIn = 50, Quality = 80 } };

        var app = new GildedRose(items);
        app.UpdateQuality();

        var item = items.First();

        Assert.That(item.Quality, Is.EqualTo(80));
        Assert.That(item.SellIn, Is.EqualTo(50));
    }
}