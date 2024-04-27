using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class ViksWaresTest
    {
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellBy = 0, Value = 0 } };
            ViksWares app = new ViksWares(Items);
            app.UpdateValue();
            Assert.AreEqual("fixme", Items[0].Name);
        }
    }
}