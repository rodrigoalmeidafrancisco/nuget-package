using ExtensionCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace ExtensionCoreTest
{
    [TestClass]
    public class DecimalExtensionTest
    {
        private string _val;
        private decimal _valueReturn;

        public DecimalExtensionTest()
        {
           
        }

        [TestMethod]
        public void Test_ToDecimal()
        {
            _val = "892694,12";
            _valueReturn = _val.ToDecimal();
            _valueReturn = DecimalExtension.ToDecimal(_val);
            Assert.AreEqual(_valueReturn, 892694.12M);

            _val = "892 694,12";
            _valueReturn = _val.ToDecimal(NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, "fr-FR");
            _valueReturn = DecimalExtension.ToDecimal(_val, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, "fr-FR");
            Assert.AreEqual(_valueReturn, 892694.12M);
        }

    }
}
