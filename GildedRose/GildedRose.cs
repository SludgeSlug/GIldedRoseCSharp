using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<Item> _items;

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

            if (item.Name.Equals(ItemNames.AgedBrie))
            {
                item.Apreciate();
                item.SellIn--;
                if(item.SellIn < 0)
                {
                    item.Apreciate();
                }
                continue;
            }

            if (item.Name.Equals(ItemNames.BackstagePass))
            {
                item.Apreciate();
                item.SellIn--;
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
                continue;
            }

            item.Depreciate();
            item.SellIn--;
            if (item.SellIn < 0)
            {
                item.Depreciate();
            }
        }
    }
}