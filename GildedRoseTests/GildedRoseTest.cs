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
        var items = new List<Item> { new() { Name = ItemNames.Sulfuras, SellIn = 50, Quality = 80 } };

        var app = new GildedRose(items);
        app.UpdateQuality();

        var item = items.First();

        Assert.That(item.Quality, Is.EqualTo(80));
        Assert.That(item.SellIn, Is.EqualTo(50));
    }

    [Test]
    public void StandardItems_DecrementSellInAndQuality_WhenSellInIsAboveZero()
    {
        var items = new List<Item> { new() { Name = "StandardItem", SellIn = 50, Quality = 50 } };

        var app = new GildedRose(items);
        app.UpdateQuality();

        var item = items.First();

        Assert.That(item.Quality, Is.EqualTo(49));
        Assert.That(item.SellIn, Is.EqualTo(49));
    }

    [Test]
    public void StandardItems_DecrementSellInByOneAndQualityByTwo_WhenSellInIsBelowZero()
    {
        var items = new List<Item> { new() { Name = "StandardItem", SellIn = -1, Quality = 50 } };

        var app = new GildedRose(items);
        app.UpdateQuality();

        var item = items.First();

        Assert.That(item.Quality, Is.EqualTo(48));
        Assert.That(item.SellIn, Is.EqualTo(-2));
    }
}