using ExtensionCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionCoreTest
{
    [TestClass]
    public class DoubleExtensionTest
    {
        private string _val;
        private double _valueReturn;

        public DoubleExtensionTest()
        {
            
        }

        [TestMethod]
        public void Test_ToDouble()
        {
            _val = "52,8725945";
            _valueReturn = _val.ToDouble();
            _valueReturn = DoubleExtension.ToDouble(_val);
            Assert.AreEqual(_valueReturn, (double)52.8725945);

            _val = long.MaxValue.ToString();
            _valueReturn = _val.ToDouble();
            _valueReturn = DoubleExtension.ToDouble(_val);
            Assert.AreEqual(_valueReturn, (double)9.2233720368547758E+18);
        }

    }
}
