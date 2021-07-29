using NUnit.Framework;
using System;

namespace SampleUnitTest2
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            //Assert.That(2+2, Is.EqualTo(4));            //pass
            //Assert.That(2 + 2, Is.EqualTo(5));          //Fail

            //Assert.Fail("This must Fail");
            //Assert.Warn("This does not look Good");

            Warn.If(2 + 2 == 5);                      //warn if condition inside () is true, if false it passes

        }

        //[Test]
        //public void Test2()
        //{
        //    Assert.Fail();
        //}

        //[Test]
        //public void Test3()
        //{
        //    throw new Exception();
        //}
    }
}