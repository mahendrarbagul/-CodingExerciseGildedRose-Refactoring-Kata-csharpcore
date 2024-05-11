using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GildedRoseKata
{
    public class GildedRoseSolved
    {
        IList<Item> Items;
        public GildedRoseSolved(IList<Item> Items)
        {
            this.Items = Items;
        }

        public class ItemTypes
        {
            public const string AGED = "Aged Brie";
            public const string BACK = "Backstage passes to a TAFKAL80ETC concert";
            public const string SULF = "Sulfuras, Hand of Ragnaros";
            public const string NOTHING = "";
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                switch (item.Name)
                {
                    case ItemTypes.AGED:

                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                        item.SellIn = item.SellIn - 1;
                        if (item.SellIn < 0 && item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                        continue;
                    case ItemTypes.BACK:
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;

                            item.SellIn = item.SellIn - 1;
                            if (item.SellIn < 11 && item.Quality < 50)
                            {
                                item.Quality = item.Quality + 1;
                            }
                            if (item.SellIn < 6 && item.Quality < 50)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }
                        item.SellIn = item.SellIn - 1;
                        if (item.SellIn < 0)
                        {
                            item.Quality = item.Quality - item.Quality;

                        }
                        continue;
                    case ItemTypes.SULF:
                      
                        continue;
                    default:
                        if (item.Quality > 0)
                        {
                            item.Quality = item.Quality - 1;
                        }
                        item.SellIn = item.SellIn - 1;
                        if (item.SellIn < 0 && item.Quality > 0)
                        {
                            item.Quality = item.Quality - 1;
                        }
                        continue;
                }
            }
        }
    }
}
