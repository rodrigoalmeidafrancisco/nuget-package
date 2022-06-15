﻿using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HttpCore
{
    public class BaseHttpHandler
    {
        public string _phraseIdentifyRejection;
        public readonly HttpClient _client;
        private readonly bool _configureAwait;

        public BaseHttpHandler(string linkBaseAddress, bool notVerificationSSL = false, bool configureAwait = false, CookieContainer cookieContainer = null,
            string phraseIdentifyRejection = null)
        {
            _configureAwait = configureAwait;

            HttpClientHandler clientHandler = new HttpClientHandler();

            if (notVerificationSSL)
            {
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            }

            if (cookieContainer != null)
            {
                clientHandler.CookieContainer = cookieContainer;
                clientHandler.UseCookies = true;
            }

            _client = new HttpClient(clientHandler)
            {
                BaseAddress = new Uri(linkBaseAddress)
            };

            _phraseIdentifyRejection = phraseIdentifyRejection;
        }

        public void AddDefaultRequestHeaders(string authenticationScheme = "Bearer", string authenticationParameter = "", string mediaType = "application/json")
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType));
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(authenticationScheme, authenticationParameter);
        }

        public void AddBearerTokenRequest(string token, string mediaType = "application/json")
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType));
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        #region Get

        public async Task<ResultHttp> GetAsync(string requestUri, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.GetAsync(requestUri, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> GetAsync(Uri requestUri, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.GetAsync(requestUri, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.GetAsync(requestUri, completionOption, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.GetAsync(requestUri, completionOption, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        #endregion Get

        #region Post

        public async Task<ResultHttp> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.PostAsync(requestUri, content, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.PostAsync(requestUri, content, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> PostStringContentAsync(string requestUri, string json, Encoding encoding, string mediaType = "application/json", CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.PostAsync(requestUri, new StringContent(json, encoding, mediaType), cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> PostStringContentAsync(Uri requestUri, string json, Encoding encoding, string mediaType = "application/json", CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.PostAsync(requestUri, new StringContent(json, encoding, mediaType), cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        #endregion Post

        #region Put

        public async Task<ResultHttp> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.PutAsync(requestUri, content, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.PutAsync(requestUri, content, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> PutStringContentAsync(string requestUri, string json, Encoding encoding, string mediaType = "application/json", CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.PutAsync(requestUri, new StringContent(json, encoding, mediaType), cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> PutStringContentAsync(Uri requestUri, string json, Encoding encoding, string mediaType = "application/json", CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.PutAsync(requestUri, new StringContent(json, encoding, mediaType), cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        #endregion Put

        #region Delete

        public async Task<ResultHttp> DeleteAsync(string requestUri, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.DeleteAsync(requestUri, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> DeleteAsync(Uri requestUri, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.DeleteAsync(requestUri, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        #endregion Delete

        private async Task<ResultHttp> GetResultHttp(HttpResponseMessage response)
        {
            ResultHttp resultHttp = new ResultHttp() { Response = response, HttpStatusCode = response.StatusCode };

            try
            {
                resultHttp.DataString = await response.Content.ReadAsStringAsync();
            }
            catch
            {
            }

            try
            {
                resultHttp.DataBytes = await response.Content.ReadAsByteArrayAsync();
            }
            catch
            {
            }

            try
            {
                resultHttp.DataStream = await response.Content.ReadAsStreamAsync();
            }
            catch
            {
            }

            if (_phraseIdentifyRejection != null)
            {
                resultHttp.RequestRejected = resultHttp.DataString.ToUpper().Contains(_phraseIdentifyRejection.ToUpper());
            }

            return resultHttp;
        }

    }
}
