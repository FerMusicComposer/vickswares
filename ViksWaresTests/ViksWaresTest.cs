using ViksWares;

namespace ViksWaresTests
{
    [TestFixture]
    public class ViksWaresTest
    {
        [Test]
        public void Foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellBy = 0, Value = 0 } };
            ViksWares.ViksWares app = new ViksWares.ViksWares(Items);
            app.UpdateValue();
            Assert.That(Items[0].Name, Is.EqualTo("fixme"));
        }
    }
}