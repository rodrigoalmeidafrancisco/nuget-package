namespace ExtensionCoreTest.Commum
{
    public class EntitieTest
    {
        public EntitieTest(int valueInt, string valueString, EnumTest valueEnum)
        {
            ValueInt = valueInt;
            ValueString = valueString;
            ValueEnum = valueEnum;
        }

        public int ValueInt { get; set; }

        public string ValueString { get; set; }

        public EnumTest ValueEnum { get; set; }

    }
}
