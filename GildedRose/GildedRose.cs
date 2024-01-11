using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<Item> _items;
    private const int MaxQuality = 50;

    public GildedRose(IList<Item> items)
    {
        _items = items;
    }

    public void UpdateQuality()
    {
        foreach (var item in _items)
        {
            if (item.Name.Equals(ItemNames.Sulfuras))
            {
                continue;
            }

            if (item.Name != ItemNames.AgedBrie && item.Name != ItemNames.BackstagePass)
            {
                item.Depreciate();
                item.SellIn--;
                if (item.SellIn < 0)
                {
                    item.Depreciate();
                }
                continue;
            }

            item.Apreciate();
            item.SellIn--;

            if (item.Name == ItemNames.BackstagePass)
            {
                if (item.SellIn < 0)
                {
                    item.Quality = 0;
                    continue;
                }
                if (item.SellIn < 10)
                {
                    item.Apreciate();
                }
                if (item.SellIn < 5)
                {
                    item.Apreciate();
                }
            }

            if (item.SellIn < 0 && item.Name == ItemNames.AgedBrie)
            {
                item.Apreciate();
            }
        }
    }
}