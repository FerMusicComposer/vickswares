using ViksWares.Models;

namespace ViksWaresTests;

[TestFixture]
public class ViksWaresTest
{
    [Test]
    public void ValueUpdaterServiceTest()
    {
        IList<Item> items = new List<Item>
        {
            new Item { Name = "foo", SellBy = 10, Value = 20 },
            new Item {Name = "Aged Parmigiano", SellBy = 2, Value = 0},
        };
        
        var app = new ViksWares.Application.ViksWares(items);
        app.UpdateValue();
        Assert.Multiple(() =>
        {
            Assert.That(items[0].SellBy, Is.EqualTo(9));
            Assert.That(items[0].Value, Is.EqualTo(19));
            Assert.That(items[1].SellBy, Is.EqualTo(1));
            Assert.That(items[1].Value, Is.EqualTo(1));
        });
    }

    [Test]
    public void ConcertTicketsValueUpdaterTest()
    {
        IList<Item> items = new List<Item>
        {
            new Item
            {
                Name = "Concert tickets to Talkins Festival",
                SellBy = 15,
                Value = 20
            },
            new Item
            {
                Name = "Concert tickets to Talkins Festival",
                SellBy = 10,
                Value = 47
            },
            new Item
            {
                Name = "Concert tickets to Talkins Festival",
                SellBy = 5,
                Value = 45
            },
            new Item
            {
                Name = "Concert tickets to Talkins Festival",
                SellBy = 0,
                Value = 48
            }
        };
        
        var app = new ViksWares.Application.ViksWares(items);
        app.UpdateValue();
        Assert.Multiple(() =>
            {
                Assert.That(items[0].SellBy, Is.EqualTo(14));
                Assert.That(items[0].Value, Is.EqualTo(21));
                Assert.That(items[1].SellBy, Is.EqualTo(9));
                Assert.That(items[1].Value, Is.EqualTo(49));
                Assert.That(items[2].SellBy, Is.EqualTo(4));
                Assert.That(items[2].Value, Is.EqualTo(48));
                Assert.That(items[3].SellBy, Is.EqualTo(-1));
                Assert.That(items[3].Value, Is.EqualTo(0)); 
            });
    }
    
    [Test]
    public void RefrigeratedItemValueUpdaterTest()
    {
        IList<Item> items = new List<Item>
        {
            new Item { Name = "Refrigerated Gouda Cheese", SellBy = 10, Value = 8 },
            new Item {Name = "Refrigerated Strawberry Shake", SellBy = 0, Value = 3},
            new Item {Name = "Refrigerated milk", SellBy = -3, Value = 6}
        };
        
        var app = new ViksWares.Application.ViksWares(items);
        app.UpdateValue();
        Assert.Multiple(() =>
        {
            Assert.That(items[0].SellBy, Is.EqualTo(9));
            Assert.That(items[0].Value, Is.EqualTo(6));
            Assert.That(items[1].SellBy, Is.EqualTo(-1));
            Assert.That(items[1].Value, Is.EqualTo(1));
            Assert.That(items[2].SellBy, Is.EqualTo(-4));
            Assert.That(items[2].Value, Is.EqualTo(2));
        });
    }
    
    [Test]
    public void NormalItemValueUpdaterTest()
    {
        IList<Item> items = new List<Item>
        {
            new Item {Name = "Shoe Laces", SellBy = 19, Value = 20},
            new Item {Name = "Green Bell Peppers", SellBy = -2, Value = 2},
            new Item {Name = "Book of Resolutions", SellBy = -1, Value = 1},
        };
        
        var app = new ViksWares.Application.ViksWares(items);
        app.UpdateValue();
        Assert.Multiple(() =>
        {
            Assert.That(items[0].SellBy, Is.EqualTo(18));
            Assert.That(items[0].Value, Is.EqualTo(19));
            Assert.That(items[1].SellBy, Is.EqualTo(-3));
            Assert.That(items[1].Value, Is.EqualTo(0));
            Assert.That(items[2].SellBy, Is.EqualTo(-2));
            Assert.That(items[2].Value, Is.EqualTo(0));
        });
    }
    
    [Test]
    public void ParmigianoUpdaterServiceTest()
    {
        IList<Item> items = new List<Item>
        {
            new Item { Name = "Deluxe Parmigiano", SellBy = -4, Value = 50 },
            new Item {Name = "Aged Parmigiano", SellBy = 2, Value = 32},
        };
        
        var app = new ViksWares.Application.ViksWares(items);
        app.UpdateValue();
        Assert.Multiple(() =>
        {
            Assert.That(items[0].SellBy, Is.EqualTo(-5));
            Assert.That(items[0].Value, Is.EqualTo(50));
            Assert.That(items[1].SellBy, Is.EqualTo(1));
            Assert.That(items[1].Value, Is.EqualTo(33));
        });
    }
}

