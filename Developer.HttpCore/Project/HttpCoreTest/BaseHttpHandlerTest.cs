using ExtensionCore;
using HttpCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace HttpCoreTest
{
    [TestClass]
    public class BaseHttpHandlerTest
    {
        private string _uriAPI_ViaCEP = "https://viacep.com.br/";

        public BaseHttpHandlerTest()
        {

        }

        [TestMethod]
        public async Task Test_001()
        {
            //Criando o clientHttp
            BaseHttpHandler baseHttpHandler = new(_uriAPI_ViaCEP, true);

            //Realizando a chamada para a API e obtendo os dados de retorno.
            ResultHttp resultHttp = await baseHttpHandler.GetAsync("ws/01001000/json/");

            switch (resultHttp.HttpStatusCode)
            {
                case HttpStatusCode.OK:

                    string json = resultHttp.DataString;
                    Assert.IsTrue(json.IsNullOrEmptyOrWhiteSpace() == false);

                    break;

                default:

                    Assert.Fail();

                    break;
            }
        }

        [TestMethod]
        public async Task Test_002()
        {
            //Parâmetros para o cookie
            var valueCookie = HttpUtility.UrlEncode("0123456789");

            //Criando o Cookie Container
            CookieContainer cookieContainer = new();
            cookieContainer.Add(new Uri(_uriAPI_ViaCEP), new Cookie("Key", valueCookie));

            //Criando o clientHttp
            BaseHttpHandler baseHttpHandler = new(_uriAPI_ViaCEP, true, false, cookieContainer);

            //Realizando a chamada para a API e obtendo os dados de retorno.
            ResultHttp resultHttp = await baseHttpHandler.GetAsync("ws/01001000/json/");

            switch (resultHttp.HttpStatusCode)
            {
                case HttpStatusCode.OK:

                    string json = resultHttp.DataString;
                    Assert.IsTrue(json.IsNullOrEmptyOrWhiteSpace() == false);

                    break;

                default:

                    Assert.Fail();

                    break;
            }
        }


    }
}
