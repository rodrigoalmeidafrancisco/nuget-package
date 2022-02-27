using ExtensionCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExtensionCoreTest
{
    [TestClass]
    public class BoolExtensionTest
    {
        public bool valReturn;

        public BoolExtensionTest()
        {
           
        }

        [TestMethod]
        public void Test_IsBetween_DateTime()
        {
            DateTime val = DateTime.Now;

            valReturn = val.IsBetween(DateTime.Now.AddMinutes(-5), DateTime.Now.AddMinutes(5));
            Assert.AreEqual(true, valReturn);

            valReturn = val.IsBetween(DateTime.Now.AddMinutes(-5), val);
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsBetween(val, DateTime.Now.AddMinutes(-5), DateTime.Now.AddMinutes(5));
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsBetween(val, DateTime.Now.AddMinutes(5), DateTime.Now.AddMinutes(10));
            Assert.AreEqual(false, valReturn);
        }

        [TestMethod]
        public void Test_IsBetween_Int()
        {
            int val = int.MaxValue - 100;

            valReturn = val.IsBetween(int.MinValue, int.MaxValue);
            Assert.AreEqual(true, valReturn);

            valReturn = val.IsBetween(int.MinValue, val);
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsBetween(val, int.MinValue, int.MaxValue);
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsBetween(val, int.MaxValue - 50, int.MaxValue);
            Assert.AreEqual(false, valReturn);
        }

        [TestMethod]
        public void Test_IsBetween_Long()
        {
            long val = long.MaxValue - 100;

            valReturn = val.IsBetween(long.MinValue, long.MaxValue);
            Assert.AreEqual(true, valReturn);

            valReturn = val.IsBetween(long.MinValue, val);
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsBetween(val, long.MinValue, long.MaxValue);
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsBetween(val, long.MaxValue - 50, long.MaxValue);
            Assert.AreEqual(false, valReturn);
        }

        [TestMethod]
        public void Test_IsBetween_Decimal()
        {
            decimal val = decimal.MaxValue - 100;

            valReturn = val.IsBetween(decimal.MinValue, decimal.MaxValue);
            Assert.AreEqual(true, valReturn);

            valReturn = val.IsBetween(decimal.MinValue, val);
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsBetween(val, decimal.MinValue, decimal.MaxValue);
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsBetween(val, decimal.MaxValue - 50, decimal.MaxValue);
            Assert.AreEqual(false, valReturn);
        }

        [TestMethod]
        public void Test_IsBetween_Float()
        {
            float valTest = 500.45E-2f;
            float valSub1 = 134.45E-2f;
            float valSub2 = 300.45E-2f;

            float val = valTest - valSub2;

            valReturn = val.IsBetween(float.MinValue, float.MaxValue);
            Assert.AreEqual(true, valReturn);

            valReturn = val.IsBetween(float.MinValue, val);
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsBetween(val, float.MinValue, float.MaxValue);
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsBetween(val, float.MaxValue - valSub1, float.MaxValue);
            Assert.AreEqual(false, valReturn);
        }

        [TestMethod]
        public void Test_IsBetween_Double()
        {
            double valTest = 500.45E-2f;
            double valSub1 = 134.45E-2f;
            double valSub2 = 300.45E-2f;

            double val = valTest - valSub2;

            valReturn = val.IsBetween(double.MinValue, double.MaxValue);
            Assert.AreEqual(true, valReturn);

            valReturn = val.IsBetween(double.MinValue, val);
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsBetween(val, double.MinValue, double.MaxValue);
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsBetween(val, valTest - valSub1, double.MaxValue);
            Assert.AreEqual(false, valReturn);
        }

        [TestMethod]
        public void Test_IsBetween_TimeSpan()
        {
            TimeSpan valMax = TimeSpan.MaxValue;
            TimeSpan valSub100 = new TimeSpan(100);
            TimeSpan valSub500 = new TimeSpan(500);

            TimeSpan val = valMax - valSub500;

            valReturn = val.IsBetween(TimeSpan.MinValue, TimeSpan.MaxValue);
            Assert.AreEqual(true, valReturn);

            valReturn = val.IsBetween(TimeSpan.MinValue, val);
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsBetween(val, TimeSpan.MinValue, TimeSpan.MaxValue);
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsBetween(val, TimeSpan.MaxValue - valSub100, TimeSpan.MaxValue);
            Assert.AreEqual(false, valReturn);
        }

        [TestMethod]
        public void Test_IsNullOrEmpty()
        {
            string val = null;

            valReturn = val.IsNullOrEmpty();
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsNullOrEmpty(val);
            Assert.AreEqual(true, valReturn);

            val = "test";
            
            valReturn = val.IsNullOrEmpty();
            Assert.AreEqual(false, valReturn);

            valReturn = BoolExtension.IsNullOrEmpty(val);
            Assert.AreEqual(false, valReturn);
        }

        [TestMethod]
        public void Test_IsNullOrWhiteSpace()
        {
            string val = null;

            valReturn = val.IsNullOrWhiteSpace();
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsNullOrWhiteSpace(val);
            Assert.AreEqual(true, valReturn);

            val = " ";

            valReturn = val.IsNullOrWhiteSpace();
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsNullOrWhiteSpace(val);
            Assert.AreEqual(true, valReturn);

            val = "      ";

            valReturn = val.IsNullOrWhiteSpace();
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsNullOrWhiteSpace(val);
            Assert.AreEqual(true, valReturn);

            val = "test";

            valReturn = val.IsNullOrWhiteSpace();
            Assert.AreEqual(false, valReturn);

            valReturn = BoolExtension.IsNullOrWhiteSpace(val);
            Assert.AreEqual(false, valReturn);
        }

        [TestMethod]
        public void Test_IsNullOrEmptyOrWhiteSpace()
        {
            string val = null;

            valReturn = val.IsNullOrEmptyOrWhiteSpace();
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsNullOrEmptyOrWhiteSpace(val);
            Assert.AreEqual(true, valReturn);

            val = " ";

            valReturn = val.IsNullOrEmptyOrWhiteSpace();
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsNullOrEmptyOrWhiteSpace(val);
            Assert.AreEqual(true, valReturn);

            val = "      ";

            valReturn = val.IsNullOrEmptyOrWhiteSpace();
            Assert.AreEqual(true, valReturn);

            valReturn = BoolExtension.IsNullOrEmptyOrWhiteSpace(val);
            Assert.AreEqual(true, valReturn);

            val = "test";

            valReturn = val.IsNullOrEmptyOrWhiteSpace();
            Assert.AreEqual(false, valReturn);

            valReturn = BoolExtension.IsNullOrEmptyOrWhiteSpace(val);
            Assert.AreEqual(false, valReturn);
        }
    }
}
