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

            if (item.Quality < MaxQuality)
            {
                item.Quality++;

                if (item.Name == ItemNames.BackstagePass)
                {
                    if (item.SellIn < 11)
                    {
                        if (item.Quality < MaxQuality)
                        {
                            item.Quality++;
                        }
                    }

                    if (item.SellIn < 6)
                    {
                        if (item.Quality < MaxQuality)
                        {
                            item.Quality++;
                        }
                    }
                }
            }

            item.SellIn--;

            if (item.SellIn < 0)
            {
                if (item.Name != ItemNames.AgedBrie)
                {
                    if (item.Name != ItemNames.BackstagePass)
                    {
                        item.Depreciate();
                    }
                    else
                    {
                        item.Quality -= item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < MaxQuality)
                    {
                        item.Quality++;
                    }
                }
            }
        }
    }
}