using ExtensionCore;
using ExtensionCoreTest.Commum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionCoreTest
{
    [TestClass]
    public class ByteExtensionTest
    {
        public byte valbyteReturn;
        public byte[] valbyteArrayReturn;

        public ByteExtensionTest()
        {
           
        }

        [TestMethod]
        public void Test_ToByte_String()
        {
            string val = "5";
            valbyteReturn = val.ToByte();
            Assert.AreEqual(5, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(val);
            Assert.AreEqual(5, valbyteReturn);

            val = "";
            valbyteReturn = val.ToByte();
            Assert.AreEqual(0, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(val);
            Assert.AreEqual(0, valbyteReturn);

            val = "  ";
            valbyteReturn = val.ToByte();
            Assert.AreEqual(0, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(val);
            Assert.AreEqual(0, valbyteReturn);

            val = "Teste";
            valbyteReturn = val.ToByte();
            Assert.AreEqual(0, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(val);
            Assert.AreEqual(0, valbyteReturn);

            val = string.Empty;
            valbyteReturn = val.ToByte();
            Assert.AreEqual(0, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(val);
            Assert.AreEqual(0, valbyteReturn);

            val = null;
            valbyteReturn = val.ToByte();
            Assert.AreEqual(0, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(val);
            Assert.AreEqual(0, valbyteReturn);
        }

        [TestMethod]
        public void Test_ToByte_Enum()
        {
            valbyteReturn = EnumTest.Teste0.ToByte();
            Assert.AreEqual(0, valbyteReturn);

            valbyteReturn = EnumTest.Teste1.ToByte();
            Assert.AreEqual(1, valbyteReturn);

            valbyteReturn = EnumTest.Teste2.ToByte();
            Assert.AreEqual(2, valbyteReturn);
        }

        [TestMethod]
        public void Test_ToBytesScaleImage()
        {
            valbyteArrayReturn = valbyteArrayReturn.ToBytesScaleImage(2);
            Assert.AreEqual(null, valbyteArrayReturn);
            valbyteArrayReturn = ByteExtension.ToBytesScaleImage(null, 2);
            Assert.AreEqual(null, valbyteArrayReturn);
        }

        [TestMethod]
        public void Test_ToBytesPathFile()
        {
            string pathFile = null;
            valbyteArrayReturn = pathFile.ToBytesPathFile();
            Assert.AreEqual(null, valbyteArrayReturn);
            valbyteArrayReturn = ByteExtension.ToBytesPathFile(pathFile);
            Assert.AreEqual(null, valbyteArrayReturn);



        }

    }
}
