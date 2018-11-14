using Xunit;

namespace Refactor.Kata.Tests
{
    public class GildedRoseTests
    {
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
    }
}
