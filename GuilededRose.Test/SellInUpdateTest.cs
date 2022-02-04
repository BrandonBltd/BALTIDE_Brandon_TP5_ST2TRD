using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace GuilededRose.Test
{
    public class SellInUpdateTest
    {
        [Test]
        public void SellInShouldDecreaseAfterEachDay()
        {
            var passes = new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 8};
            IList<Item> Items = new List<Item>
            {
                passes
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(3,passes.SellIn );


        }
    }
}