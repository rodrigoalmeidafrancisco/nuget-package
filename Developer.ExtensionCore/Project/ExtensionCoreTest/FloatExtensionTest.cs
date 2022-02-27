using ExtensionCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionCoreTest
{
    [TestClass]
    public class FloatExtensionTest
    {
        private string _val;
        private float _valueReturn;

        public FloatExtensionTest()
        {
           
        }

        [TestMethod]
        public void Test_ToFloat()
        {
            _val = "41.00027357629127";
            _valueReturn = _val.ToFloat(); 
            _valueReturn = FloatExtension.ToFloat(_val);

            Assert.AreEqual(_valueReturn, (float)4.10002732E+15);
        }

    }
}
