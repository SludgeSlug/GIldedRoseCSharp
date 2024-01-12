namespace GildedRoseKata
{
    public static class ItemExtensions
    {
        public const int MaxQuality = 50;

        public static void Depreciate(this Item item, int factor)
        {
            for (var i = 0; i < factor; i++)
            {
                item.Depreciate();
            }
        }

        public static void Depreciate(this Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }
        }

        public static void Apreciate(this Item item)
        {
            if (item.Quality < MaxQuality)
            {
                item.Quality++;
            }
        }
    }
}
