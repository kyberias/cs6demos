using NUnit.Framework;
using cs6demos;

namespace cs6demotests
{
    [TestFixture]
    public class Demo5Test
    {
        [Test]
        public void Name()
        {
            var demo5 = new Demo5
            {
                FirstName = "Urho",
                LastName = "Kekkonen"
            };

            Assert.AreEqual("Urho Kekkonen", demo5.Name);
        }
    }
}
