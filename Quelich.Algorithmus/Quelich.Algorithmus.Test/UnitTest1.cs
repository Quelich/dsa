using NUnit.Framework;
using Quelich.Algorithmus;

namespace Quelich.Algorithmus.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, euclid_algorithm(6,3));
        }
    }
}