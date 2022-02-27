using ExtensionCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExtensionCoreTest
{
    [TestClass]
    public class GuidExtensionTest
    {
        private string _val;
        private Guid _valueReturn;

        public GuidExtensionTest()
        {

        }

        [TestMethod]
        public void Test_ToGuid()
        {
            _val = "fd104832-13f1-4b42-9fee-211b9030a6ce";
            _valueReturn = _val.ToGuid();
            Assert.AreEqual(_valueReturn.ToString(), _val);
        }

    }
}
