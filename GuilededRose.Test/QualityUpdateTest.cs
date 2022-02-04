using System;
using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace GuilededRose.Test
{
    [TestFixture]
    public class QualityUpdateTest
    {
        [Test]
        public void QualityShouldNeverBeLowerThanZero()
        {
            var obj = new Item {Name = "+5 Dexterity Vest", SellIn = 0, Quality = 0};
            IList<Item> Items = new List<Item>
            {
              
                obj
              
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            
            Assert.AreEqual(0,obj.Quality );  
            
                
        }

        [Test]
        public void QualityShouldNeverBeMoreThanFifty()
        {
            IList<Item> Items = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 50 },
                
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50,Items[0].Quality );  
            
        }

        [Test]
        public void QualityOfSulfurasShouldAlwaysBeEighty()
        {

            var MACCESTNUUUUUUUUUUUL = new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80};
            IList<Item> Items = new List<Item>
            {
              MACCESTNUUUUUUUUUUUL  
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(80,MACCESTNUUUUUUUUUUUL.Quality );
            
            
            
        }
        
        [Test]
        public void QualityShouldIncreaseOfOneForBrie()
        {
            var fromage = new Item {Name = "Aged Brie", SellIn = 10, Quality = 8};
            IList<Item> Items = new List<Item>
            {
                fromage
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(9,fromage.Quality );


        }
        

        [Test]
        public void QualityDegenerateTwiceRatherQuicklyAfterExpiryDate()
        {
            var obj1 = new Item {Name = "+5 Dexterity Vest", SellIn = -1, Quality = 8};
            IList<Item> Items = new List<Item>
            {
                obj1
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(6,obj1.Quality );


        }
        [Test]
        public void QualityOfBackStageIncreaseOfTwoWhenSellinBetweenTenAndFive()
        {
            var passes = new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 8};
            IList<Item> Items = new List<Item>
            {
                passes
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(10,passes.Quality );


        }
        
        [Test]
        public void QualityOfBackStageIncreaseOfThreeWhenSellinBetweenFiveAndOne()
        {
            var passes2 = new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 8};
            IList<Item> Items = new List<Item>
            {
                passes2
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(11,passes2.Quality );


        }
        
        [Test]
        public void QualityOfBackStageShouldBeZeroWhenSellinEqualsZero()
        {
            var passes3 = new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 8};
            IList<Item> Items = new List<Item>
            {
                passes3
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0,passes3.Quality );


        }
        
        [Test]
        public void QualityOfConjuredDecreaseTwiceRatherQuicklyThanOther()
        {
            var passes2 = new Item {Name = "Conjured", SellIn = 4, Quality = 8};
            IList<Item> Items = new List<Item>
            {
                passes2
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(11,passes2.Quality );


        }
        
        
        
        
        
    }
}