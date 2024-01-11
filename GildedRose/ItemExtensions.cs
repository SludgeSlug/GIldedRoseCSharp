namespace GildedRoseKata
{
    public static class ItemExtensions
    {
        public static void Depreciate(this Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }
        }
    }
}
