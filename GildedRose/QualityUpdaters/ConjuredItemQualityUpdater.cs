namespace GildedRoseKata.QualityUpdaters
{
    public class ConjuredItemQualityUpdater : IQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;
            if (item.SellIn < 0)
            {
                item.Depreciate(4);
            }
            else
            {
                item.Depreciate(2);
            }
        }
    }
}
