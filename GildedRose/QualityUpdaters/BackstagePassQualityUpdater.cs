namespace GildedRoseKata.QualityUpdaters
{
    public class BackstagePassQualityUpdater : IQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            item.Apreciate();
            item.SellIn--;
            if (item.SellIn < 0)
            {
                item.Quality = 0;
                return;
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
    }
}
