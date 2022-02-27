using ExtensionCore;
using ExtensionCoreTest.Commum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionCoreTest
{
    [TestClass]
    public class IntExtensionTest
    {
        private string _val;
        private int _valueReturn;
        private int? _valueReturnNull;

        public IntExtensionTest()
        {

        }

        [TestMethod]
        public void Test_ToInt_string()
        {
            _val = "10";
            _valueReturn = _val.ToInt();
            Assert.AreEqual(_valueReturn, 10);
        }

        [TestMethod]
        public void Test_ToInt_Enum()
        {
            _valueReturn = EnumTest.Teste0.ToInt();
            Assert.AreEqual(_valueReturn, 0);

            _valueReturn = EnumTest.Teste1.ToInt();
            Assert.AreEqual(_valueReturn, 1);

            _valueReturn = EnumTest.Teste2.ToInt();
            Assert.AreEqual(_valueReturn, 2);
        }

        [TestMethod]
        public void Test_ToIntNull_string()
        {
            _val = "10";
            _valueReturnNull = _val.ToIntNull();
            Assert.AreEqual(_valueReturnNull, 10);

            _val = "AAA";
            _valueReturnNull = _val.ToIntNull();
            Assert.AreEqual(_valueReturnNull, null);
        }

        [TestMethod]
        public void Test_ToIntNull_Enum()
        {
            _valueReturnNull = EnumTest.Teste0.ToInt();
            Assert.AreEqual(_valueReturnNull, 0);

            _valueReturnNull = EnumTest.Teste1.ToInt();
            Assert.AreEqual(_valueReturnNull, 1);

            _valueReturnNull = EnumTest.Teste2.ToInt();
            Assert.AreEqual(_valueReturnNull, 2);
        }


    }
}
