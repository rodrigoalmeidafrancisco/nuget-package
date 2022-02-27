using System.ComponentModel;

namespace ExtensionCoreTest.Commum
{
    public enum EnumTest
    {
        Teste0 = 0,
        [Description("Teste 1")]
        Teste1 = 1,
        [Description("Teste 2")]
        Teste2 = 2
    }
}
