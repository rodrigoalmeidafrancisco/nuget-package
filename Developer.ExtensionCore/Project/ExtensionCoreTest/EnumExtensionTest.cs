using ExtensionCore;
using ExtensionCore.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionCoreTest
{
    [TestClass]
    public class EnumExtensionTest
    {
        [TestMethod]
        public void Test_GetDescription()
        {
            string description = EnumCountryCulture.Afar_Djibouti.GetDescription();
            Assert.AreEqual("aa-DJ", description);
        }

        [TestMethod]
        public void Test_GetListDescriptionEnum()
        {
            IEnumerable<string> list = EnumExtension.GetListDescriptionEnum<EnumCountryCulture>();
            Assert.IsTrue(list.Count() > 0);
        }

        [TestMethod]
        public void Test_GetListDescriptionEnumDropDown()
        {
            IEnumerable<KeyValuePair<int, string>> list = EnumExtension.GetListDescriptionEnumDropDown<EnumCountryCulture>();
            Assert.IsTrue(list.Count() > 0);
        }

    }
}
