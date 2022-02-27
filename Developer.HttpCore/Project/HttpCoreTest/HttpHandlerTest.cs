using HttpCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace HttpCoreTest
{
    [TestClass]
    public class HttpHandlerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Task task = Task.Run(async () => 
            {
                BaseHttpHandler baseHttpHandler = new("https://viacep.com.br/", true);
                var teste = await baseHttpHandler.GetAsync("ws/01001000/json/");
            });

            task.Wait();
        }
    }
}
