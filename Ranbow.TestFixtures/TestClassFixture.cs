using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ranbow;

namespace Ranbow.TestFixtures
{
    [TestFixture]
    public class TestClassFixture
    {
        [Test]
        public void Test_This()
        {
            var testClass = TestClass.GetInstance();
            var addThis = 4;
            var andThis = 7;
            var expectedValue = 11;
            var result = testClass.TestAdding(addThis, andThis);

            Assert.AreEqual(expectedValue, result);
        }

    }
}
