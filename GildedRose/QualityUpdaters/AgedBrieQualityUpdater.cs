namespace GildedRoseKata.QualityUpdaters
{
    public class AgedBrieQualityUpdater : IQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            item.Apreciate();
            item.SellIn--;
            if (item.SellIn < 0)
            {
                item.Apreciate();
            }
        }
    }
}
