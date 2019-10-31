using NUnit.Framework;
using CommHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace CommHelper.Tests
{
    [TestFixture()]
    public class TestHelperTests
    {
        [Test()]
        public void CheckTest()
        {
            TestHelper helper = new TestHelper();
            Assert.True(helper.Check("Frankie"));
        }

        [Test()]
        public void IsIntTest()
        {
            TestHelper helper = new TestHelper();
            Assert.True(helper.IsInt("1"));
        }

        [Test()]
        public void IsInt1Test()
        {
            Assert.True(true);
        }

        [Test()]
        public void IsStringTest()
        {
            Assert.True(true);
        }

        [Test()]
        public void Import1Test()
        {
            var mock = new Mock<IExcelHelper>();
            mock.Setup(b => b.Import(It.IsAny<string>())).Returns(true);

            Assert.True(mock.Object.Import("test"));
        }

        [Test()]
        public void IsError()
        {
            Assert.True(false);
        }
    }
}