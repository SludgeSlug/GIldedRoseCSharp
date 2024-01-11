namespace GildedRoseKata.QualityUpdaters
{
    public class ConjuredItemQualityUpdater : IQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            item.Depreciate();
            item.Depreciate();
            item.SellIn--;
            if (item.SellIn < 0)
            {
                item.Depreciate();
                item.Depreciate();
            }
        }
    }
}
