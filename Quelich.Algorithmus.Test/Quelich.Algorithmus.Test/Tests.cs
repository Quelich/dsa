using System;
using NUnit.Framework;
using Quelich.Algorithmus.Models;
namespace Quelich.Algorithmus.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var euclid = euclid_algorithm();
            Assert.AreEqual(euclid.Solution())
        }
    }
}