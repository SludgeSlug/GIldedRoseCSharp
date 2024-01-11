using GildedRoseKata;
using GildedRoseKata.QualityUpdaters;

namespace GildedRoseKata
{
    public class QualityUpdaterFactory
    {
        public static IQualityUpdater CreateQualityUpdater(Item item)
        {
            return item.Name switch
            {
                ItemNames.AgedBrie => new AgedBrieQualityUpdater(),
                ItemNames.BackstagePass => new BackstagePassQualityUpdater(),
                ItemNames.Sulfuras => new SulfurasQualityUpdater(),
                _ => new StandardItemQualityUpdater(),
            };
        }
    }
}
