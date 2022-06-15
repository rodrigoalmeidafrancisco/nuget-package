using System.IO;
using System.Net;
using System.Net.Http;

namespace HttpCore
{
    public class ResultHttp
    {
        public ResultHttp()
        {
            DataString = null;
            DataBytes = null;
        }

        public HttpResponseMessage Response { get; set; }

        public HttpStatusCode HttpStatusCode { get; set; }

        public string DataString { get; set; }

        public byte[] DataBytes { get; set; }

        public Stream DataStream { get; set; }
        
        public bool RequestRejected { get; set; }
    }
}
