using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
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
    }
}