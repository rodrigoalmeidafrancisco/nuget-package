using ExtensionCore;
using ExtensionCoreTest.Commum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionCoreTest
{
    [TestClass]
    public class JsonExtensionTest
    {
        private EntitieTest _valueEntitieTest;
        private int _valueInt;
        private string _valueJson;

        [TestMethod]
        public void Test_ToSerializeJsonTextJson()
        {
            _valueEntitieTest = new EntitieTest(5, "Test", EnumTest.Teste1);
            _valueJson = _valueEntitieTest.ToSerializeJsonTextJson();

            if (!_valueJson.IsNullOrEmptyOrWhiteSpace())
            {
                Assert.IsTrue(true);
            }

            _valueInt = 50;
            _valueJson = _valueInt.ToSerializeJsonTextJson();

            if (!_valueJson.IsNullOrEmptyOrWhiteSpace())
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Test_ToDeserializeJsonTextJson()
        {
            _valueEntitieTest = new EntitieTest(5, "Test", EnumTest.Teste1);
            _valueJson = _valueEntitieTest.ToSerializeJsonTextJson();

            if (!_valueJson.IsNullOrEmptyOrWhiteSpace())
            {
                EntitieTest entitieTest = _valueJson.ToDeserializeJsonTextJson<EntitieTest>();

                if (entitieTest != null)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.Fail();
                }
            }
            else
            {
                Assert.Fail();
            }

            _valueInt = 50;
            _valueJson = _valueInt.ToSerializeJsonTextJson();

            if (!_valueJson.IsNullOrEmptyOrWhiteSpace())
            {
                int valInt = _valueJson.ToDeserializeJsonTextJson<int>();
                Assert.AreEqual(valInt, _valueInt);
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Test_ToSerializeJsonNewtonsoft()
        {
            _valueEntitieTest = new EntitieTest(5, "Test", EnumTest.Teste1);
            _valueJson = _valueEntitieTest.ToSerializeJsonNewtonsoft();

            if (!_valueJson.IsNullOrEmptyOrWhiteSpace())
            {
                Assert.IsTrue(true);
            }

            _valueInt = 50;
            _valueJson = _valueInt.ToSerializeJsonNewtonsoft();

            if (!_valueJson.IsNullOrEmptyOrWhiteSpace())
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Test_ToDeserializeJsonNewtonsoft()
        {
            _valueEntitieTest = new EntitieTest(5, "Test", EnumTest.Teste1);
            _valueJson = _valueEntitieTest.ToSerializeJsonNewtonsoft();

            if (!_valueJson.IsNullOrEmptyOrWhiteSpace())
            {
                EntitieTest entitieTest = _valueJson.ToDeserializeJsonNewtonsoft<EntitieTest>();

                if (entitieTest != null)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.Fail();
                }
            }
            else
            {
                Assert.Fail();
            }

            _valueInt = 50;
            _valueJson = _valueInt.ToSerializeJsonNewtonsoft();

            if (!_valueJson.IsNullOrEmptyOrWhiteSpace())
            {
                int valInt = _valueJson.ToDeserializeJsonNewtonsoft<int>();
                Assert.AreEqual(valInt, _valueInt);
            }
            else
            {
                Assert.Fail();
            }
        }


    }
}
