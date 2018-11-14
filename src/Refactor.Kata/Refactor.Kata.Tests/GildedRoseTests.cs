using Xunit;

namespace Refactor.Kata.Tests
{
    public class GildedRoseTests
    {
        [Fact]
        public void GivenANormalItemWhenUpdating_ThenQualityShouldDiminish()
        {
            var instance = new GildedRose("normal", 5, 10);
            instance.Tick();

            Assert.Equal(9, instance.Quality);
            Assert.Equal(4, instance.SellIn);
        }

        [Fact]
        public void GivenANormalItemPastSellByDate_ThenQualityShouldDiminishTwiceAsFast()
        {

            var instance = new GildedRose("normal", 0, 10);
            instance.Tick();

            Assert.Equal(8, instance.Quality);
            Assert.Equal(-1, instance.SellIn);
        }

        [Fact]
        public void GivenAgedBrie_ThenQualityShouldIncrease()
        {
            var instance = new GildedRose("Aged Brie", 5, 10);
            instance.Tick();

            Assert.Equal(11, instance.Quality);
            Assert.Equal(4, instance.SellIn);
        }

        [Fact]
        public void GivenAgedBrieWhichShouldBeSoldYesterday_ThenQualityIncreases()
        {
            var instance = new GildedRose("Aged Brie", 0, 10);
            instance.Tick();

            Assert.Equal(12, instance.Quality);
            Assert.Equal(-1, instance.SellIn);
        }

        [Fact]
        public void GivenMaximumQualityAgedBrieWhichShouldHaveBeenSoldYesterday_ThenQualityRemains()
        {
            var instance = new GildedRose("Aged Brie", 0, 51);
            instance.Tick();

            Assert.Equal(51, instance.Quality);
            Assert.Equal(-1, instance.SellIn);
        }

        [Fact]
        public void GivenSulfurasWhenUpdating_NothingShouldChange()
        {
            var instance = new GildedRose("Sulfuras, Hand of Ragnaros", 10, 10);
            instance.Tick();

            Assert.Equal(10, instance.Quality);
            Assert.Equal(10, instance.SellIn);
        }

        [Fact]
        public void GivenSulfurasPastSellByWhenUpdating_NothingShouldChange()
        {
            var instance = new GildedRose("Sulfuras, Hand of Ragnaros", 0, 10);
            instance.Tick();

            Assert.Equal(10, instance.Quality);
            Assert.Equal(0, instance.SellIn);
        }

        [Fact]
        public void GivenInfinityGauntletWhenUpdating_NothingShouldChange()
        {
            var instance = new GildedRose("Infinity Gauntlet", 10, 10);
            instance.Tick();

            Assert.Equal(10, instance.Quality);
            Assert.Equal(10, instance.SellIn);
        }

        [Fact]
        public void GivenInfinityGauntletPastSellByWhenUpdating_NothingShouldChange()
        {
            var instance = new GildedRose("Infinity Gauntlet", 0, 10);
            instance.Tick();

            Assert.Equal(10, instance.Quality);
            Assert.Equal(0, instance.SellIn);
        }

        [Theory]
        [InlineData(12, 10, 11)]
        [InlineData(12, 50, 50)]
        [InlineData(11, 10, 11)]
        [InlineData(11, 50, 50)]
        [InlineData(10, 10, 12)]
        [InlineData(10, 50, 50)]
        [InlineData(9, 10, 12)]
        [InlineData(9, 50, 50)]
        [InlineData(8, 10, 12)]
        [InlineData(8, 50, 50)]
        [InlineData(7, 10, 12)]
        [InlineData(7, 50, 50)]
        [InlineData(6, 10, 12)]
        [InlineData(6, 50, 50)]
        [InlineData(5, 10, 13)]
        [InlineData(5, 50, 50)]
        [InlineData(4, 10, 13)]
        [InlineData(4, 50, 50)]
        [InlineData(3, 10, 13)]
        [InlineData(3, 50, 50)]
        [InlineData(2, 10, 13)]
        [InlineData(2, 50, 50)]
        [InlineData(1, 10, 14)]
        [InlineData(1, 50, 50)]
        [InlineData(0, 10, 0)]
        [InlineData(0, 50, 0)]
        public void GivenConcertTickets_ThenExpectedQualityIsReturned(int sellIn, int quantity, int expectedQuantity)
        {
            var instance = new GildedRose("Backstage passes to a TAFKAL80ETC concert", sellIn, quantity);
            instance.Tick();

            Assert.Equal(expectedQuantity, instance.Quality);
            Assert.Equal(sellIn - 1, instance.SellIn);
        }

        [Fact(Skip = "New Functionality")]
        public void GivenConjuredWhenUpdating_QualityDegradesFaster()
        {
            var instance = new GildedRose("Conjured Doll", 10, 10);
            instance.Tick();

            Assert.Equal(8, instance.Quality);
            Assert.Equal(9, instance.SellIn);
        }

        [Fact(Skip = "New Functionality")]
        public void GivenConjuredPastSellByDateWhenUpdating_QualityDegradesDoublyFast()
        {
            var instance = new GildedRose("Conjured Doll", 10, 10);
            instance.Tick();

            Assert.Equal(6, instance.Quality);
            Assert.Equal(9, instance.SellIn);
        }
    }
}
