namespace GildedRoseKata.QualityUpdaters
{
    public class StandardItemQualityUpdater : IQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;
            if (item.SellIn < 0)
            {
                item.Depreciate(2);
            }
            else
            {
                item.Depreciate();
            }
        }
    }
}
