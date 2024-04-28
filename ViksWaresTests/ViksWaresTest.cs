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
                SellBy = -1,
                Value = 49
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
                Assert.That(items[3].SellBy, Is.EqualTo(-2));
                Assert.That(items[3].Value, Is.EqualTo(0));
                Assert.That(items[4].SellBy, Is.EqualTo(-1));
                Assert.That(items[4].Value, Is.EqualTo(50)); // check value increases on concert day (SellBy = 0) and that it doesn't go above 50
            });
    }
}