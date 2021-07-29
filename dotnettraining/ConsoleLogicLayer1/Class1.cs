using System;

namespace CoreLogicLayer1
{
    internal class TestAccess
    {
        public int TAProp { get; set; }
        Test.TestAcrossNamespace obj = new Test.TestAcrossNamespace();
        IAmPrivate obj2 = new IAmPrivate();
        IAmInternal obj3 = new IAmInternal();

        private class IAmPrivate
        {
            public int IAPProp { get; set; }

        }
        internal class IAmInternal
        {
            public int IAIProp { get; set; }

        }
    }
    public class IAmPublic
    {
        public int IAPuProp { get; set; }


    }
}
namespace Test
{
    internal class TestAcrossNamespace
    {
        public int DifferentNameSpaceProp { get; set; }


    }
}
