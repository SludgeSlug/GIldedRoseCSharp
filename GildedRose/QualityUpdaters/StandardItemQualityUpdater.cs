namespace GildedRoseKata.QualityUpdaters
{
    public class StandardItemQualityUpdater : IQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            item.Depreciate();
            item.SellIn--;
            if (item.SellIn < 0)
            {
                item.Depreciate();
            }
        }
    }
}
