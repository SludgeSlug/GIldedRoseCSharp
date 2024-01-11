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
        var items = GetSingleItemList(ItemNames.Sulfuras, 50, 80);
        UpdateQuality(items);

        var item = items.First();

        Assert.That(item.Quality, Is.EqualTo(80));
        Assert.That(item.SellIn, Is.EqualTo(50));
    }

    [Test]
    public void StandardItems_DecrementSellInAndQuality_WhenSellInIsAboveZero()
    {
        var items = GetSingleItemList("StandardItem", 50, 50);
        UpdateQuality(items);

        var item = items.First();

        Assert.That(item.Quality, Is.EqualTo(49));
        Assert.That(item.SellIn, Is.EqualTo(49));
    }

    [Test]
    public void StandardItems_DecrementSellInByOneAndQualityByTwo_WhenSellInIsBelowZero()
    {
        var items = GetSingleItemList("StandardItem", -1, 50);
        UpdateQuality(items);

        var item = items.First();

        Assert.That(item.Quality, Is.EqualTo(48));
        Assert.That(item.SellIn, Is.EqualTo(-2));
    }

    [Test]
    public void BackStagePass_MaintainsQuality_WhenSellInIsOver10Days()
    {
        var items = GetSingleItemList(ItemNames.BackstagePass, 11, 50);
        UpdateQuality(items);

        var item = items.First();

        Assert.That(item.Quality, Is.EqualTo(50));
    }

    [Test]
    public void BackStagePass_IncreasesQualityByTwo_WhenSellInLessThanEleven()
    {
        var items = GetSingleItemList(ItemNames.BackstagePass, 10, 40);
        UpdateQuality(items);

        var item = items.First();

        Assert.That(item.Quality, Is.EqualTo(42));
    }

    [Test]
    public void BackStagePass_IncreasesQualityByThree_WhenSellInLessThanSix()
    {
        var items = GetSingleItemList(ItemNames.BackstagePass, 5, 40);
        UpdateQuality(items);

        var item = items.First();

        Assert.That(item.Quality, Is.EqualTo(43));
    }

    [Test]
    public void BackStagePass_DoesNotIncreaseQualityBeyondMaximum()
    {
        var items = GetSingleItemList(ItemNames.BackstagePass, 5, 50);
        UpdateQuality(items);

        var item = items.First();

        Assert.That(item.Quality, Is.EqualTo(50));
    }

    [Test]
    public void BackStagePass_QualitySetToZero_WhenSellInLessThanZero()
    {
        var items = GetSingleItemList(ItemNames.BackstagePass, -1, 40);
        UpdateQuality(items);

        var item = items.First();

        Assert.That(item.Quality, Is.EqualTo(0));
    }

    private static List<Item> GetSingleItemList(string name, int sellIn, int quality) =>
        new() { new() { Name = name, SellIn = sellIn, Quality = quality } };

    private static void UpdateQuality(List<Item> items)
    {
        var app = new GildedRose(items);
        app.UpdateQuality();
    }
}