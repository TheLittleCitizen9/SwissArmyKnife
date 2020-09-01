using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Linq;
using TestMe;

namespace SwissArmyKnife
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1_ParseStringToInt_Parses_Correctly()
        {
            string number = "1";

            var swiisArmyKnife = new TestMe.SwissArmyKnife();

            int result = swiisArmyKnife.ParseStringToInt(number);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void Test2_ParseStringToInt_Parses_Exception()
        {
            string number = "1#";

            var swiisArmyKnife = new TestMe.SwissArmyKnife();

            Assert.Throws<ArgumentException>(() => swiisArmyKnife.ParseStringToInt(number));
        }

        [Test]
        public void Test3_PickFreshestFruit_Exception()
        {
            FruitProvider fruitProvider = new FruitProvider();
            var swiisArmyKnife = new TestMe.SwissArmyKnife();
            var mock = new Mock<TestMe.ILogger>();
            mock.Setup(x => x.Log(It.IsAny<string>()));

            try
            {
                swiisArmyKnife.PickFreshestFruit(fruitProvider, mock.Object);
            }
            catch(Exception e)
            {

            }
            mock.Verify(x => x.Log(It.IsAny<string>()), Times.Once());
        }

        [Test]
        public void Test4_PickFreshestFruit_Correctly()
        {
            IFruitProvider fruitProvider = new StubFruitProvider();
            var swiisArmyKnife = new TestMe.SwissArmyKnife();
            var mock = new Mock<TestMe.ILogger>();
            mock.Setup(x => x.Log(It.IsAny<string>()));

            var freshestFruit = swiisArmyKnife.PickFreshestFruit(fruitProvider, mock.Object);

            Assert.AreEqual(2, freshestFruit.FreshnessLevel);
        }
    }
}