using ViksWares;
using ViksWares.Models;

namespace ViksWaresTests;

[TestFixture]
public class ViksWaresTest
{
    [Test]
    public void Foo()
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
}