namespace Refactor.Kata
{
    public class GildedRose
    {
        private readonly string _name;

        public int SellIn { get; private set; }
        public int Quality { get; private set; }

        public GildedRose(string name, int sellIn, int quality)
        {
            _name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public void Tick()
        {
            if (_name != "Aged Brie" && _name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (Quality > 0)
                {
                    if (_name != "Sulfuras, Hand of Ragnaros" && _name != "Infinity Gauntlet")
                    {
                        Quality = Quality - 1;
                    }
                }
            }
            else
            {
                if (Quality < 50)
                {
                    Quality = Quality + 1;

                    if (_name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (SellIn < 11)
                        {
                            if (Quality < 50)
                            {
                                Quality = Quality + 1;
                            }
                        }

                        if (SellIn < 6)
                        {
                            if (Quality < 50)
                            {
                                Quality = Quality + 1;
                            }
                        }

                        if (SellIn < 2)
                        {
                            if (Quality < 50)
                            {
                                Quality = Quality + 1;
                            }
                        }
                    }
                }
            }

            if (_name != "Sulfuras, Hand of Ragnaros" && _name != "Infinity Gauntlet")
            {
                SellIn = SellIn - 1;
            }

            if (SellIn < 0)
            {
                if (_name != "Aged Brie")
                {
                    if (_name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (Quality > 0)
                        {
                            if (_name != "Sulfuras, Hand of Ragnaros" && _name != "Infinity Gauntlet")
                            {
                                Quality = Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        Quality = Quality - Quality;
                    }
                }
                else
                {
                    if (Quality < 50)
                    {
                        Quality = Quality + 1;
                    }
                }
            }
        }
    }
}